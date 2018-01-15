using LiteDB;

namespace GMailMonitor
{
    public class SenderFlat
    {
        [BsonId]
        public string Sender { get; set; }
        public string FlatNumber { get; set; }
    }
}