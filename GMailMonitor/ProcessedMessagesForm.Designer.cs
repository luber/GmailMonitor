namespace GMailMonitor
{
    partial class ProcessedMessagesForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcessedMessagesForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.messageDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senderAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flatNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meterReadingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailSubjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailBodyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meterReadingMessageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.meterReadingMessageBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 500);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 51);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 36);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(784, 464);
            this.panel3.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.messageDateDataGridViewTextBoxColumn,
            this.senderAddressDataGridViewTextBoxColumn,
            this.flatNumberDataGridViewTextBoxColumn,
            this.meterReadingDataGridViewTextBoxColumn,
            this.mailSubjectDataGridViewTextBoxColumn,
            this.mailBodyDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.meterReadingMessageBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(784, 464);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.toolStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 36);
            this.panel2.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 36);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(118, 33);
            this.toolStripButton1.Text = "Зберегти в файл";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // messageDateDataGridViewTextBoxColumn
            // 
            this.messageDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.messageDateDataGridViewTextBoxColumn.DataPropertyName = "MessageDate";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.messageDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.messageDateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.messageDateDataGridViewTextBoxColumn.Name = "messageDateDataGridViewTextBoxColumn";
            this.messageDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.messageDateDataGridViewTextBoxColumn.Width = 58;
            // 
            // senderAddressDataGridViewTextBoxColumn
            // 
            this.senderAddressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.senderAddressDataGridViewTextBoxColumn.DataPropertyName = "SenderAddress";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.senderAddressDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.senderAddressDataGridViewTextBoxColumn.HeaderText = "Відправник";
            this.senderAddressDataGridViewTextBoxColumn.Name = "senderAddressDataGridViewTextBoxColumn";
            this.senderAddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.senderAddressDataGridViewTextBoxColumn.Width = 89;
            // 
            // flatNumberDataGridViewTextBoxColumn
            // 
            this.flatNumberDataGridViewTextBoxColumn.DataPropertyName = "FlatNumber";
            this.flatNumberDataGridViewTextBoxColumn.HeaderText = "№ квартири";
            this.flatNumberDataGridViewTextBoxColumn.Name = "flatNumberDataGridViewTextBoxColumn";
            // 
            // meterReadingDataGridViewTextBoxColumn
            // 
            this.meterReadingDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.meterReadingDataGridViewTextBoxColumn.DataPropertyName = "MeterReading";
            this.meterReadingDataGridViewTextBoxColumn.HeaderText = "Показник";
            this.meterReadingDataGridViewTextBoxColumn.Name = "meterReadingDataGridViewTextBoxColumn";
            this.meterReadingDataGridViewTextBoxColumn.Width = 82;
            // 
            // mailSubjectDataGridViewTextBoxColumn
            // 
            this.mailSubjectDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mailSubjectDataGridViewTextBoxColumn.DataPropertyName = "MailSubject";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mailSubjectDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.mailSubjectDataGridViewTextBoxColumn.HeaderText = "Тема листа";
            this.mailSubjectDataGridViewTextBoxColumn.Name = "mailSubjectDataGridViewTextBoxColumn";
            this.mailSubjectDataGridViewTextBoxColumn.ReadOnly = true;
            this.mailSubjectDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // mailBodyDataGridViewTextBoxColumn
            // 
            this.mailBodyDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mailBodyDataGridViewTextBoxColumn.DataPropertyName = "MailBody";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mailBodyDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.mailBodyDataGridViewTextBoxColumn.HeaderText = "Тіло листа";
            this.mailBodyDataGridViewTextBoxColumn.Name = "mailBodyDataGridViewTextBoxColumn";
            this.mailBodyDataGridViewTextBoxColumn.ReadOnly = true;
            this.mailBodyDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // meterReadingMessageBindingSource
            // 
            this.meterReadingMessageBindingSource.AllowNew = false;
            this.meterReadingMessageBindingSource.DataSource = typeof(GMailMonitor.MeterReadingMessage);
            this.meterReadingMessageBindingSource.Sort = "MessageDate DESC";
            // 
            // ProcessedMessagesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 551);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ProcessedMessagesForm";
            this.ShowIcon = false;
            this.Text = "Перегляд показників";
            this.Load += new System.EventHandler(this.ProcessedMessagesForm_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.meterReadingMessageBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource meterReadingMessageBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn messageDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senderAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flatNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn meterReadingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailSubjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailBodyDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}