using System;
using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using GMailMonitor.Properties;
using ImapX;
using Microsoft.Win32;

namespace GMailMonitor
{
    public class AppContext : ApplicationContext
    {
        private readonly NotifyIcon _notifyIcon;
        private readonly Container _components;

        private ImapClient _imapClient;

        private MessageProcessor _messageProcessor;
        private AppRepository _appEntitiesRepo;

        private readonly BindingList<MeterReadingMessage> _meterReadingMessages;

        public AppContext()
        {
            _components = new System.ComponentModel.Container();
            _notifyIcon = new NotifyIcon(_components)
            {
                ContextMenuStrip = new ContextMenuStrip(),
                Icon = Icon.ExtractAssociatedIcon(Assembly.GetEntryAssembly().Location),
//                Text = "Парсер показників з поштової скриньки",
                Visible = true
            };

//            _notifyIcon.ContextMenuStrip.Opening += ContextMenuStrip_Opening;
            _notifyIcon.DoubleClick += notifyIcon_DoubleClick;

            SetupContextMenu();

            SetupDb();

            var prevMessages = _appEntitiesRepo
                .Fetch<MeterReadingMessage>() // TODO: filter to get last 2 month only
                .ToList();

            _meterReadingMessages = new BindingList<MeterReadingMessage>(prevMessages);

            StartMonitorigThread();
        }

        private void SetupDb()
        {
            var connectionStr = ConfigurationManager.ConnectionStrings["ReadingsDB"].ConnectionString;
            _appEntitiesRepo = new AppRepository(connectionStr);

            var sendersCollections = _appEntitiesRepo.Database.GetCollection<SenderFlat>();
            sendersCollections.EnsureIndex(x => x.Sender);

            var mrCollection = _appEntitiesRepo.Database.GetCollection<MeterReadingMessage>();
            mrCollection.EnsureIndex(x => x.SenderAddress);
        }

        private void StartMonitorigThread()
        {
            if (string.IsNullOrEmpty(Settings.Default.ImapSrv) || string.IsNullOrEmpty(Settings.Default.ImapUser) || string.IsNullOrEmpty(Settings.Default.ImapPwd))
            {
                _notifyIcon.ShowBalloonTip(1000, "Помилка", "Перевірте налаштування.", ToolTipIcon.Error);
            }
            else
            {
                try
                {
                    if (_imapClient != null)
                    {
                        _imapClient.Logout();
                        _imapClient.Disconnect();
                        _imapClient.Folders.Inbox.OnNewMessagesArrived -= Inbox_OnNewMessagesArrived;
                        _imapClient.Dispose();
                    }

                    _imapClient = new ImapClient(Settings.Default.ImapSrv, (int) Settings.Default.SslPort, true);

                    if (_imapClient.Connect())
                    {
                        if (_imapClient.Login(Settings.Default.ImapUser, Settings.Default.ImapPwd))
                        {
                            _messageProcessor = new MessageProcessor(_appEntitiesRepo, Settings.Default.FlatNumberRegex, Settings.Default.MeterReadingRegex);

                            _imapClient.Folders.Inbox.OnNewMessagesArrived += Inbox_OnNewMessagesArrived;
                            if (_imapClient.Folders.Inbox.StartIdling())
                            {
                                _notifyIcon.ShowBalloonTip(1000, string.Empty, "Чекаю на нові листи...", ToolTipIcon.Info);
                            }
                            else
                            {
                                _notifyIcon.ShowBalloonTip(1000, "Помилка", "Неможу почати слухати папку Inbox", ToolTipIcon.Error);
                            }
                        }
                        else
                        {
                            _notifyIcon.ShowBalloonTip(1000, "Помилка", "Перевірте логін та пароль!", ToolTipIcon.Error);
                        }
                    }
                    else
                    {
                        _notifyIcon.ShowBalloonTip(1000, "Помилка", "З'єднання невдале.", ToolTipIcon.Error);
                    }
                }
                catch (Exception exception)
                {
                    _notifyIcon.ShowBalloonTip(1000, "Помилка", exception.Message, ToolTipIcon.Error);
                }
            }
        }

        private void Inbox_OnNewMessagesArrived(object sender, IdleEventArgs e)
        {
            foreach (var message in e.Messages.OrderByDescending(m => m.Date ?? DateTime.Now))
            {
                var date = message.Date ?? DateTime.Now;
                var from = message.From.Address;
                var msgSubject = message.Subject;
                var msgBody = message.Body.Text;

                var processedMessage = _messageProcessor.Process(date, from, msgSubject, msgBody);

                _meterReadingMessages.Insert(0, processedMessage);

                _appEntitiesRepo.Insert(processedMessage);

                if (!string.IsNullOrEmpty(processedMessage.FlatNumber))
                {
                    _appEntitiesRepo.Upsert(new SenderFlat { Sender = processedMessage.SenderAddress, FlatNumber = processedMessage.FlatNumber});
                }
            }
        }

        private void SetupContextMenu()
        {
            _notifyIcon.ContextMenuStrip.Items.Add("Перегляд показників", null, OnReadingMessagesClick);
            _notifyIcon.ContextMenuStrip.Items.Add(new ToolStripSeparator());
            _notifyIcon.ContextMenuStrip.Items.Add("Налаштування", null, OnSettingsClick);
            _notifyIcon.ContextMenuStrip.Items.Add(new ToolStripSeparator());
            _notifyIcon.ContextMenuStrip.Items.Add("Вихід", null, OnExitMenuIconClick);
        }

        private void OnReadingMessagesClick(object sender, EventArgs e)
        {
//            _meterReadingMessages.Add(new MeterReadingMessage
//            {
//                FlatNumber = "194",
//                MailBody = "​показник 14,24",
//                MailSubject = "​кв 194",
//                MessageDate = DateTime.Now,
//                SenderAddress = "lubomirv@gmail.com",
//                MeterReading = 14.24
//            });
//
//            _meterReadingMessages.Add(new MeterReadingMessage
//            {
//                FlatNumber = "191",
//                MailBody = "​показник 12,24",
//                MailSubject = "​кв 191",
//                MessageDate = DateTime.Now.AddMinutes(-5),
//                SenderAddress = "lubomirv2@gmail.com",
//                MeterReading = 12.24
//            });

            using (var readingMessagesForm = new ProcessedMessagesForm(_appEntitiesRepo, _meterReadingMessages))
            {
                readingMessagesForm.ShowDialog();
            }
        }

        private void OnSettingsClick(object sender, EventArgs eventArgs)
        {
            using (var settings = new SettingsForm())
            {
                if (settings.ShowDialog() == DialogResult.OK)
                {
                    Settings.Default.Save();

                    SetAutoStart(true); // TODO: add option

                    StartMonitorigThread();
                }
                else
                {
                    Settings.Default.Reload();
                }
            }
        }

        private void SetAutoStart(bool needAutoStart)
        {
            var rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (rk == null)
                return;

            if (needAutoStart)
            {
                rk.SetValue("GMailMonitor", Application.ExecutablePath);
            }
            else
                rk.DeleteValue("GMailMonitor", false);

        }


        private void OnExitMenuIconClick(object sender, EventArgs eventArgs)
        {
            Application.Exit();
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            OnReadingMessagesClick(sender, e);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _components?.Dispose();
            }

            base.Dispose(disposing);
        }

        protected override void ExitThreadCore()
        {
//            if (_mainForm != null)
//            {
//                _mainForm.Close();
//            }

            _notifyIcon.Visible = false; // should remove lingering tray icon!

            base.ExitThreadCore();
        }

        protected override void OnMainFormClosed(object sender, EventArgs e)
        {
            base.OnMainFormClosed(sender, e);
        }
    }
}