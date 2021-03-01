namespace SimairaDigital.Backend.ItemManagement.Cache
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Threading.Tasks;
    using Moq;
    using StackExchange.Redis;
    using StackExchange.Redis.Profiling;

    public class FakeMultiplexer : IConnectionMultiplexer
    {
#pragma warning disable 67
        public event EventHandler<RedisErrorEventArgs> ErrorMessage;

        public event EventHandler<ConnectionFailedEventArgs> ConnectionFailed;

        public event EventHandler<InternalErrorEventArgs> InternalError;

        public event EventHandler<ConnectionFailedEventArgs> ConnectionRestored;

        public event EventHandler<EndPointEventArgs> ConfigurationChanged;

        public event EventHandler<EndPointEventArgs> ConfigurationChangedBroadcast;

        public event EventHandler<HashSlotMovedEventArgs> HashSlotMoved;
#pragma warning restore 67

        public string ClientName => throw new NotSupportedException();

        public string Configuration => throw new NotSupportedException();

        public int TimeoutMilliseconds => throw new NotSupportedException();

        public long OperationCount => throw new NotSupportedException();

        public bool PreserveAsyncOrder { get => throw new NotSupportedException(); set => throw new NotSupportedException(); }

        public bool IsConnected => throw new NotSupportedException();

        public bool IsConnecting => throw new NotSupportedException();

        public bool IncludeDetailInExceptions { get => throw new NotSupportedException(); set => throw new NotSupportedException(); }

        public int StormLogThreshold { get => throw new NotSupportedException(); set => throw new NotSupportedException(); }

        public IDatabase GetDatabase(int db = -1, object asyncState = null)
        {
            return new FakeDatabase();
        }

        public void Close(bool allowCommandsToComplete = true)
        {
            throw new NotSupportedException();
        }

        public Task CloseAsync(bool allowCommandsToComplete = true)
        {
            throw new NotSupportedException();
        }

        public bool Configure(TextWriter log = null)
        {
            throw new NotSupportedException();
        }

        public Task<bool> ConfigureAsync(TextWriter log = null)
        {
            throw new NotSupportedException();
        }

        public void Dispose()
        {
            // Do nothing because there is nothing to dispose.
        }

        public void ExportConfiguration(Stream destination, ExportOptions options = (ExportOptions)(-1))
        {
            throw new NotSupportedException();
        }

        public ServerCounters GetCounters()
        {
            throw new NotSupportedException();
        }

        public EndPoint[] GetEndPoints(bool configuredOnly = false)
        {
            return new EndPoint[] { new TestEndpoint { Address = "localhost:4711", }, };
        }

        public int GetHashSlot(RedisKey key)
        {
            throw new NotSupportedException();
        }

        public IServer GetServer(string host, int port, object asyncState = null)
        {
            throw new NotSupportedException();
        }

        public IServer GetServer(string hostAndPort, object asyncState = null)
        {
            throw new NotSupportedException();
        }

        public IServer GetServer(IPAddress host, int port)
        {
            throw new NotSupportedException();
        }

        public IServer GetServer(EndPoint endpoint, object asyncState = null)
        {
            var serverMock = new Mock<IServer>();
            var keys = Enumerable.Range(0, 10)
                .Select(i =>
                {
                    var key = default(RedisKey);
                    return key;
                }).ToList();
            serverMock.Setup(server => server.Keys(It.IsAny<int>(), It.IsAny<RedisValue>(), It.IsAny<int>(), It.IsAny<long>(), It.IsAny<int>(), It.IsAny<CommandFlags>()))
                .Returns(keys);
            return serverMock.Object;
        }

        public string GetStatus()
        {
            throw new NotSupportedException();
        }

        public void GetStatus(TextWriter log)
        {
            throw new NotSupportedException();
        }

        public string GetStormLog()
        {
            throw new NotSupportedException();
        }

        public ISubscriber GetSubscriber(object asyncState = null)
        {
            throw new NotSupportedException();
        }

        public int HashSlot(RedisKey key)
        {
            throw new NotSupportedException();
        }

        public long PublishReconfigure(CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> PublishReconfigureAsync(CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public void RegisterProfiler(Func<ProfilingSession> profilingSessionProvider)
        {
            throw new NotSupportedException();
        }

        public void ResetStormLog()
        {
            throw new NotSupportedException();
        }

        public void Wait(Task task)
        {
            throw new NotSupportedException();
        }

        public T Wait<T>(Task<T> task)
        {
            throw new NotSupportedException();
        }

        public void WaitAll(params Task[] tasks)
        {
            throw new NotSupportedException();
        }

        private class TestEndpoint
            : EndPoint
        {
            public string Address { get; set; }
        }
    }
}
