using System.IO;
using LiteDB;

namespace GMailMonitor
{
    public interface IFlatsRepository
    {
        string FindFlatNumberBySender(string sender);
    }

    public class AppRepository : LiteRepository, IFlatsRepository
    {
        public AppRepository(LiteDatabase database, bool disposeDatabase = false) : base(database, disposeDatabase)
        {
        }

        public AppRepository(string connectionString, BsonMapper mapper = null) : base(connectionString, mapper)
        {
        }

        public AppRepository(ConnectionString connectionString, BsonMapper mapper = null) : base(connectionString, mapper)
        {
        }

        public AppRepository(Stream stream, BsonMapper mapper = null, string password = null) : base(stream, mapper, password)
        {
        }

        public string FindFlatNumberBySender(string sender)
        {
            var senderFlat = FirstOrDefault<SenderFlat>(x => x.Sender == sender);

            return senderFlat?.FlatNumber;
        }

    }
}