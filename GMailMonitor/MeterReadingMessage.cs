using System;

namespace GMailMonitor
{
    public class MeterReadingMessage
    {
        public int Id { get; set; }
        public string SenderAddress { get; set; }
        public string FlatNumber { get; set; }

        public DateTime MessageDate { get; set; }

        public double MeterReading { get; set; }

        public string MailSubject { get; set; }
        public string MailBody { get; set; }
    }
}