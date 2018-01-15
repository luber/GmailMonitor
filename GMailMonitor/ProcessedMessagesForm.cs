using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GMailMonitor
{
    public partial class ProcessedMessagesForm : Form
    {
        private readonly AppRepository _repository;
        private readonly BindingList<MeterReadingMessage> _meterReadingMessages;

        public ProcessedMessagesForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        public ProcessedMessagesForm(AppRepository repository, BindingList<MeterReadingMessage> meterReadingMessages): this()
        {
            _repository = repository;
            _meterReadingMessages = meterReadingMessages;
        }

        private void ProcessedMessagesForm_Load(object sender, EventArgs e)
        {
            meterReadingMessageBindingSource.DataSource = _meterReadingMessages;
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var columnDataPropName = dataGridView1.Columns[e.ColumnIndex].DataPropertyName;
            if ((columnDataPropName == "FlatNumber" || columnDataPropName == "MeterReading") && e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];

                var cellValue = row.Cells[e.ColumnIndex].Value;
                var backColor = cellValue == null ? Color.Red : Color.Green;
                
                row.DefaultCellStyle.BackColor = backColor;

                var dataItem = row.DataBoundItem as MeterReadingMessage;
                _repository.Update(dataItem);

                if (columnDataPropName == "FlatNumber" && !string.IsNullOrEmpty((string)cellValue))
                {
                    var mailSender = (string) row.Cells["senderAddressDataGridViewTextBoxColumn"].Value;
                    _repository.Upsert(new SenderFlat { Sender = mailSender, FlatNumber = (string)cellValue });
                }
            }
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowCount >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];

                var backColor = string.IsNullOrEmpty((string)row.Cells["flatNumberDataGridViewTextBoxColumn"].Value) ? Color.Red : Color.Green;

                row.DefaultCellStyle.BackColor = backColor;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            // TODO: Save _meterReadingMessages to csv
            using (var exportToCsvDialog = new SaveFileDialog())
            {
                exportToCsvDialog.Title = "Експорт показників";
                exportToCsvDialog.DefaultExt = "csv";
                exportToCsvDialog.Filter = "Файли з розділеними даними|*.csv";

                if (exportToCsvDialog.ShowDialog() == DialogResult.OK)
                {
                    var csv = new StringBuilder();

                    foreach (var readingMessage in _meterReadingMessages)
                    {
                        var newLine = string.Format("{0};{1}", readingMessage.FlatNumber, readingMessage.MeterReading);
                        csv.AppendLine(newLine);
                    }

                    File.WriteAllText(exportToCsvDialog.FileName, csv.ToString());
                }
            }
        }
    }
}
