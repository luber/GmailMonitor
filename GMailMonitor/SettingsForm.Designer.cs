namespace GMailMonitor
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblImapPort = new System.Windows.Forms.Label();
            this.lblConnectionResult = new System.Windows.Forms.Label();
            this.btnCheckConnection = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lvlImapSrv = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblFlatNumberRegex = new System.Windows.Forms.Label();
            this.nrSslPort = new System.Windows.Forms.NumericUpDown();
            this.chkUseSSL = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtImapSrv = new System.Windows.Forms.TextBox();
            this.txtFlatNumberRegex = new System.Windows.Forms.TextBox();
            this.lblMeterReadingRegex = new System.Windows.Forms.Label();
            this.txtMeterReadingRegex = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrSslPort)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOk);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 311);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 36);
            this.panel1.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(12, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Відміна";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(329, 6);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Гаразд";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(416, 311);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.nrSslPort);
            this.tabPage1.Controls.Add(this.lblImapPort);
            this.tabPage1.Controls.Add(this.chkUseSSL);
            this.tabPage1.Controls.Add(this.lblConnectionResult);
            this.tabPage1.Controls.Add(this.btnCheckConnection);
            this.tabPage1.Controls.Add(this.txtPassword);
            this.tabPage1.Controls.Add(this.lblPassword);
            this.tabPage1.Controls.Add(this.txtUserName);
            this.tabPage1.Controls.Add(this.lblUserName);
            this.tabPage1.Controls.Add(this.txtImapSrv);
            this.tabPage1.Controls.Add(this.lvlImapSrv);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(408, 285);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Зв\'язок";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblImapPort
            // 
            this.lblImapPort.AutoSize = true;
            this.lblImapPort.Location = new System.Drawing.Point(302, 7);
            this.lblImapPort.Name = "lblImapPort";
            this.lblImapPort.Size = new System.Drawing.Size(35, 13);
            this.lblImapPort.TabIndex = 9;
            this.lblImapPort.Text = "Порт:";
            // 
            // lblConnectionResult
            // 
            this.lblConnectionResult.AutoSize = true;
            this.lblConnectionResult.Location = new System.Drawing.Point(123, 235);
            this.lblConnectionResult.Name = "lblConnectionResult";
            this.lblConnectionResult.Size = new System.Drawing.Size(103, 13);
            this.lblConnectionResult.TabIndex = 7;
            this.lblConnectionResult.Text = "З\'єднання успішне!";
            this.lblConnectionResult.Visible = false;
            // 
            // btnCheckConnection
            // 
            this.btnCheckConnection.Location = new System.Drawing.Point(12, 230);
            this.btnCheckConnection.Name = "btnCheckConnection";
            this.btnCheckConnection.Size = new System.Drawing.Size(92, 23);
            this.btnCheckConnection.TabIndex = 6;
            this.btnCheckConnection.Text = "Перевірити...";
            this.btnCheckConnection.UseVisualStyleBackColor = true;
            this.btnCheckConnection.Click += new System.EventHandler(this.btnCheckConnection_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(9, 179);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(48, 13);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Пароль:";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(9, 131);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(95, 13);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "Ім\'я користувача:";
            // 
            // lvlImapSrv
            // 
            this.lvlImapSrv.AutoSize = true;
            this.lvlImapSrv.Location = new System.Drawing.Point(9, 7);
            this.lvlImapSrv.Name = "lvlImapSrv";
            this.lvlImapSrv.Size = new System.Drawing.Size(121, 13);
            this.lvlImapSrv.TabIndex = 0;
            this.lvlImapSrv.Text = "Адреса IMAP сервера:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtMeterReadingRegex);
            this.tabPage2.Controls.Add(this.lblMeterReadingRegex);
            this.tabPage2.Controls.Add(this.txtFlatNumberRegex);
            this.tabPage2.Controls.Add(this.lblFlatNumberRegex);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(408, 285);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Розпізнавання";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblFlatNumberRegex
            // 
            this.lblFlatNumberRegex.AutoSize = true;
            this.lblFlatNumberRegex.Location = new System.Drawing.Point(9, 7);
            this.lblFlatNumberRegex.Name = "lblFlatNumberRegex";
            this.lblFlatNumberRegex.Size = new System.Drawing.Size(215, 13);
            this.lblFlatNumberRegex.TabIndex = 0;
            this.lblFlatNumberRegex.Text = "Вираз для визначення номера квартири:";
            // 
            // nrSslPort
            // 
            this.nrSslPort.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::GMailMonitor.Properties.Settings.Default, "SslPort", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nrSslPort.Location = new System.Drawing.Point(305, 22);
            this.nrSslPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nrSslPort.Name = "nrSslPort";
            this.nrSslPort.Size = new System.Drawing.Size(95, 20);
            this.nrSslPort.TabIndex = 10;
            this.nrSslPort.UseWaitCursor = true;
            this.nrSslPort.Value = global::GMailMonitor.Properties.Settings.Default.SslPort;
            // 
            // chkUseSSL
            // 
            this.chkUseSSL.AutoSize = true;
            this.chkUseSSL.Checked = global::GMailMonitor.Properties.Settings.Default.UseSSL;
            this.chkUseSSL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUseSSL.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::GMailMonitor.Properties.Settings.Default, "UseSSL", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkUseSSL.Location = new System.Drawing.Point(12, 50);
            this.chkUseSSL.Name = "chkUseSSL";
            this.chkUseSSL.Size = new System.Drawing.Size(217, 17);
            this.chkUseSSL.TabIndex = 8;
            this.chkUseSSL.Text = "Використовувати безпечне з\'єднання";
            this.chkUseSSL.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GMailMonitor.Properties.Settings.Default, "ImapPwd", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtPassword.Location = new System.Drawing.Point(12, 195);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(388, 20);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.Text = global::GMailMonitor.Properties.Settings.Default.ImapPwd;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUserName
            // 
            this.txtUserName.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GMailMonitor.Properties.Settings.Default, "ImapUser", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtUserName.Location = new System.Drawing.Point(12, 147);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(388, 20);
            this.txtUserName.TabIndex = 3;
            this.txtUserName.Text = global::GMailMonitor.Properties.Settings.Default.ImapUser;
            // 
            // txtImapSrv
            // 
            this.txtImapSrv.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GMailMonitor.Properties.Settings.Default, "ImapSrv", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtImapSrv.Location = new System.Drawing.Point(12, 23);
            this.txtImapSrv.Name = "txtImapSrv";
            this.txtImapSrv.Size = new System.Drawing.Size(275, 20);
            this.txtImapSrv.TabIndex = 1;
            this.txtImapSrv.Text = global::GMailMonitor.Properties.Settings.Default.ImapSrv;
            // 
            // txtFlatNumberRegex
            // 
            this.txtFlatNumberRegex.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GMailMonitor.Properties.Settings.Default, "FlatNumberRegex", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtFlatNumberRegex.Location = new System.Drawing.Point(12, 24);
            this.txtFlatNumberRegex.Name = "txtFlatNumberRegex";
            this.txtFlatNumberRegex.Size = new System.Drawing.Size(388, 20);
            this.txtFlatNumberRegex.TabIndex = 1;
            this.txtFlatNumberRegex.Text = global::GMailMonitor.Properties.Settings.Default.FlatNumberRegex;
            // 
            // lblMeterReadingRegex
            // 
            this.lblMeterReadingRegex.AutoSize = true;
            this.lblMeterReadingRegex.Location = new System.Drawing.Point(9, 70);
            this.lblMeterReadingRegex.Name = "lblMeterReadingRegex";
            this.lblMeterReadingRegex.Size = new System.Drawing.Size(289, 13);
            this.lblMeterReadingRegex.TabIndex = 2;
            this.lblMeterReadingRegex.Text = "Вираз для визначення значення показника лічильника:";
            // 
            // txtMeterReadingRegex
            // 
            this.txtMeterReadingRegex.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GMailMonitor.Properties.Settings.Default, "MeterReadingRegex", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtMeterReadingRegex.Location = new System.Drawing.Point(12, 86);
            this.txtMeterReadingRegex.Name = "txtMeterReadingRegex";
            this.txtMeterReadingRegex.Size = new System.Drawing.Size(388, 20);
            this.txtMeterReadingRegex.TabIndex = 3;
            this.txtMeterReadingRegex.Text = global::GMailMonitor.Properties.Settings.Default.MeterReadingRegex;
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(416, 347);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Налаштування";
            this.TopMost = true;
            this.Validating += new System.ComponentModel.CancelEventHandler(this.SettingsForm_Validating);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrSslPort)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtImapSrv;
        private System.Windows.Forms.Label lvlImapSrv;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnCheckConnection;
        private System.Windows.Forms.Label lblConnectionResult;
        private System.Windows.Forms.CheckBox chkUseSSL;
        private System.Windows.Forms.Label lblImapPort;
        private System.Windows.Forms.NumericUpDown nrSslPort;
        private System.Windows.Forms.TextBox txtFlatNumberRegex;
        private System.Windows.Forms.Label lblFlatNumberRegex;
        private System.Windows.Forms.TextBox txtMeterReadingRegex;
        private System.Windows.Forms.Label lblMeterReadingRegex;
    }
}