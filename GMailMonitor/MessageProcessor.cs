using System;
using System.Text.RegularExpressions;

namespace GMailMonitor
{
    public class MessageProcessor
    {
        private readonly IFlatsRepository _flatsRepository;

        private readonly Regex _flatNumbeRegex;
        private readonly Regex _meterReadingRegex;

        public MessageProcessor(
            IFlatsRepository flatsRepository, 
            string flatNumberRegex = "(?:(?:[кК]вартира|[кК][вВ])[.,]?\\W(\\d+[\\wаА-яЯ]?)\\W?)", 
            string meterReadingRegex = "(\\d+[,.]?\\d+)")
        {
            _flatsRepository = flatsRepository;
            _flatNumbeRegex = new Regex(flatNumberRegex);
            _meterReadingRegex = new Regex(meterReadingRegex);
        }

        public MeterReadingMessage Process(DateTime date, string sender, string subject, string body)
        {
            var message = new MeterReadingMessage
            {
                MessageDate = date,
                SenderAddress = sender,
                MailSubject = subject,
                MailBody = body
            };

            var flatNumber = _flatsRepository.FindFlatNumberBySender(sender);
            if (string.IsNullOrEmpty(flatNumber))
            {
                flatNumber = TryDetermineFlatNumberFromEmail(subject, body);
            }

            message.FlatNumber = flatNumber;

            var meterReadingMatch = _meterReadingRegex.Match(body);
            if (meterReadingMatch.Success)
            {
                double.TryParse(meterReadingMatch.Value, out var readingValue);
                message.MeterReading = readingValue;
            }

            return message;
        }

        private string TryDetermineFlatNumberFromEmail(string subject, string body)
        {
            var result = string.Empty;

            var subjectMatch = _flatNumbeRegex.Match(subject);
            if (subjectMatch.Success && subjectMatch.Groups.Count > 1 && subjectMatch.Groups[1].Success)
            {
                return subjectMatch.Groups[1].Value;
            }

            var bodyMatch = _flatNumbeRegex.Match(body);
            if (bodyMatch.Success && bodyMatch.Groups.Count > 1 && bodyMatch.Groups[1].Success)
            {
                return bodyMatch.Groups[1].Value;
            }

            return result;
        }
    }
}