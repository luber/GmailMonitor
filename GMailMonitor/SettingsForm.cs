using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImapX;

namespace GMailMonitor
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void btnCheckConnection_Click(object sender, EventArgs e)
        {
            lblConnectionResult.Text = "З'єднання...";
            lblConnectionResult.ForeColor = SystemColors.ControlText;
            lblConnectionResult.Visible = true;

            Task.Factory.StartNew(() =>
            {
                try
                {
                    using (var client = new ImapClient(txtImapSrv.Text, (int)nrSslPort.Value, true))
                    {
                        if (client.Connect())
                        {
                            if (client.Login(txtUserName.Text, txtPassword.Text))
                            {
                                // login successful
                                SafelyUpdateResultLabel("З'єднання успішне!", Color.Green);
                            }
                            else
                            {
                                SafelyUpdateResultLabel("Перевірте логін та пароль!", Color.Red);
                            }
                        }
                        else
                        {
                            // connection not successful
                            SafelyUpdateResultLabel("З'єднання невдале.", Color.Red);
                        }
                    }
                }
                catch (Exception exception)
                {
                    SafelyUpdateResultLabel(exception.Message, Color.Red);
                }
            });
        }

        private void SafelyUpdateResultLabel(string text, Color color)
        {
            if (lblConnectionResult.InvokeRequired)
            {
                lblConnectionResult.BeginInvoke((MethodInvoker)delegate
                {
                    lblConnectionResult.ForeColor = color;
                    lblConnectionResult.Text = text;
                });
            }
            else
            {
                lblConnectionResult.ForeColor = color;
                lblConnectionResult.Text = text;
            }
        }

        private void SettingsForm_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}
