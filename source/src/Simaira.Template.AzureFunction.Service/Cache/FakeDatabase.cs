﻿namespace Simaira.Template.AzureFunction.Service.Cache
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Threading.Tasks;
    using StackExchange.Redis;

#pragma warning disable S1200
    public class FakeDatabase : IDatabase
#pragma warning restore S1200
    {
        public int Database => throw new NotSupportedException();

        public IConnectionMultiplexer Multiplexer => throw new NotSupportedException();

        public Task<RedisValue> StringGetAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            return Task.FromResult(default(RedisValue));
        }

        public Task<RedisValue[]> StringGetAsync(RedisKey[] keys, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public IBatch CreateBatch(object asyncState = null)
        {
            throw new NotSupportedException();
        }

        public ITransaction CreateTransaction(object asyncState = null)
        {
            throw new NotSupportedException();
        }

        public RedisValue DebugObject(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<RedisValue> DebugObjectAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public RedisResult Execute(string command, params object[] args)
        {
            throw new NotSupportedException();
        }

        public RedisResult Execute(string command, ICollection<object> args, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<RedisResult> ExecuteAsync(string command, params object[] args)
        {
            throw new NotSupportedException();
        }

        public Task<RedisResult> ExecuteAsync(string command, ICollection<object> args, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public bool GeoAdd(RedisKey key, double longitude, double latitude, RedisValue member, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public bool GeoAdd(RedisKey key, GeoEntry value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long GeoAdd(RedisKey key, GeoEntry[] values, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<bool> GeoAddAsync(RedisKey key, double longitude, double latitude, RedisValue member, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<bool> GeoAddAsync(RedisKey key, GeoEntry value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> GeoAddAsync(RedisKey key, GeoEntry[] values, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public double? GeoDistance(RedisKey key, RedisValue member1, RedisValue member2, GeoUnit unit = GeoUnit.Meters, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<double?> GeoDistanceAsync(RedisKey key, RedisValue member1, RedisValue member2, GeoUnit unit = GeoUnit.Meters, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public string[] GeoHash(RedisKey key, RedisValue[] members, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public string GeoHash(RedisKey key, RedisValue member, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<string[]> GeoHashAsync(RedisKey key, RedisValue[] members, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<string> GeoHashAsync(RedisKey key, RedisValue member, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public GeoPosition?[] GeoPosition(RedisKey key, RedisValue[] members, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public GeoPosition? GeoPosition(RedisKey key, RedisValue member, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<GeoPosition?[]> GeoPositionAsync(RedisKey key, RedisValue[] members, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<GeoPosition?> GeoPositionAsync(RedisKey key, RedisValue member, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public GeoRadiusResult[] GeoRadius(RedisKey key,
            RedisValue member,
            double radius,
            GeoUnit unit = GeoUnit.Meters,
            int count = -1,
            Order? order = null,
            GeoRadiusOptions options = GeoRadiusOptions.Default,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public GeoRadiusResult[] GeoRadius(RedisKey key,
            double longitude,
            double latitude,
            double radius,
            GeoUnit unit = GeoUnit.Meters,
            int count = -1,
            Order? order = null,
            GeoRadiusOptions options = GeoRadiusOptions.Default,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<GeoRadiusResult[]> GeoRadiusAsync(RedisKey key,
            RedisValue member,
            double radius,
            GeoUnit unit = GeoUnit.Meters,
            int count = -1,
            Order? order = null,
            GeoRadiusOptions options = GeoRadiusOptions.Default,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<GeoRadiusResult[]> GeoRadiusAsync(RedisKey key,
            double longitude,
            double latitude,
            double radius,
            GeoUnit unit = GeoUnit.Meters,
            int count = -1,
            Order? order = null,
            GeoRadiusOptions options = GeoRadiusOptions.Default,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public bool GeoRemove(RedisKey key, RedisValue member, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<bool> GeoRemoveAsync(RedisKey key, RedisValue member, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long HashDecrement(RedisKey key, RedisValue hashField, long value = 1, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public double HashDecrement(RedisKey key, RedisValue hashField, double value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> HashDecrementAsync(RedisKey key, RedisValue hashField, long value = 1, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<double> HashDecrementAsync(RedisKey key, RedisValue hashField, double value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public bool HashDelete(RedisKey key, RedisValue hashField, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long HashDelete(RedisKey key, RedisValue[] hashFields, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<bool> HashDeleteAsync(RedisKey key, RedisValue hashField, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> HashDeleteAsync(RedisKey key, RedisValue[] hashFields, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public bool HashExists(RedisKey key, RedisValue hashField, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<bool> HashExistsAsync(RedisKey key, RedisValue hashField, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public RedisValue HashGet(RedisKey key, RedisValue hashField, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public RedisValue[] HashGet(RedisKey key, RedisValue[] hashFields, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public HashEntry[] HashGetAll(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<HashEntry[]> HashGetAllAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<RedisValue> HashGetAsync(RedisKey key, RedisValue hashField, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<RedisValue[]> HashGetAsync(RedisKey key, RedisValue[] hashFields, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Lease<byte> HashGetLease(RedisKey key, RedisValue hashField, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<Lease<byte>> HashGetLeaseAsync(RedisKey key, RedisValue hashField, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long HashIncrement(RedisKey key, RedisValue hashField, long value = 1, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public double HashIncrement(RedisKey key, RedisValue hashField, double value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> HashIncrementAsync(RedisKey key, RedisValue hashField, long value = 1, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<double> HashIncrementAsync(RedisKey key, RedisValue hashField, double value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public RedisValue[] HashKeys(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<RedisValue[]> HashKeysAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long HashLength(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> HashLengthAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public IEnumerable<HashEntry> HashScan(RedisKey key, RedisValue pattern, int pageSize, CommandFlags flags)
        {
            throw new NotSupportedException();
        }

        public IEnumerable<HashEntry> HashScan(RedisKey key, RedisValue pattern = default, int pageSize = 10, long cursor = 0, int pageOffset = 0, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public void HashSet(RedisKey key, HashEntry[] hashFields, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public bool HashSet(RedisKey key, RedisValue hashField, RedisValue value, When when = When.Always, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task HashSetAsync(RedisKey key, HashEntry[] hashFields, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<bool> HashSetAsync(RedisKey key, RedisValue hashField, RedisValue value, When when = When.Always, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public RedisValue[] HashValues(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<RedisValue[]> HashValuesAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public bool HyperLogLogAdd(RedisKey key, RedisValue value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public bool HyperLogLogAdd(RedisKey key, RedisValue[] values, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<bool> HyperLogLogAddAsync(RedisKey key, RedisValue value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<bool> HyperLogLogAddAsync(RedisKey key, RedisValue[] values, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long HyperLogLogLength(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long HyperLogLogLength(RedisKey[] keys, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> HyperLogLogLengthAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> HyperLogLogLengthAsync(RedisKey[] keys, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public void HyperLogLogMerge(RedisKey destination, RedisKey first, RedisKey second, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public void HyperLogLogMerge(RedisKey destination, RedisKey[] sourceKeys, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task HyperLogLogMergeAsync(RedisKey destination, RedisKey first, RedisKey second, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task HyperLogLogMergeAsync(RedisKey destination, RedisKey[] sourceKeys, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public EndPoint IdentifyEndpoint(RedisKey key = default, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<EndPoint> IdentifyEndpointAsync(RedisKey key = default, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public bool IsConnected(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public bool KeyDelete(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long KeyDelete(RedisKey[] keys, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<bool> KeyDeleteAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            return Task.FromResult(true);
        }

        public Task<long> KeyDeleteAsync(RedisKey[] keys, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public byte[] KeyDump(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<byte[]> KeyDumpAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public bool KeyExists(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long KeyExists(RedisKey[] keys, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<bool> KeyExistsAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> KeyExistsAsync(RedisKey[] keys, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public bool KeyExpire(RedisKey key, TimeSpan? expiry, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public bool KeyExpire(RedisKey key, DateTime? expiry, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<bool> KeyExpireAsync(RedisKey key, TimeSpan? expiry, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<bool> KeyExpireAsync(RedisKey key, DateTime? expiry, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public TimeSpan? KeyIdleTime(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<TimeSpan?> KeyIdleTimeAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public void KeyMigrate(RedisKey key,
            EndPoint toServer,
            int toDatabase = 0,
            int timeoutMilliseconds = 0,
            MigrateOptions migrateOptions = MigrateOptions.None,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task KeyMigrateAsync(RedisKey key,
            EndPoint toServer,
            int toDatabase = 0,
            int timeoutMilliseconds = 0,
            MigrateOptions migrateOptions = MigrateOptions.None,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public bool KeyMove(RedisKey key, int database, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<bool> KeyMoveAsync(RedisKey key, int database, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public bool KeyPersist(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<bool> KeyPersistAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public RedisKey KeyRandom(CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<RedisKey> KeyRandomAsync(CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public bool KeyRename(RedisKey key, RedisKey newKey, When when = When.Always, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<bool> KeyRenameAsync(RedisKey key, RedisKey newKey, When when = When.Always, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public void KeyRestore(RedisKey key, byte[] value, TimeSpan? expiry = null, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task KeyRestoreAsync(RedisKey key, byte[] value, TimeSpan? expiry = null, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public TimeSpan? KeyTimeToLive(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<TimeSpan?> KeyTimeToLiveAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public RedisType KeyType(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<RedisType> KeyTypeAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public RedisValue ListGetByIndex(RedisKey key, long index, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<RedisValue> ListGetByIndexAsync(RedisKey key, long index, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long ListInsertAfter(RedisKey key, RedisValue pivot, RedisValue value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> ListInsertAfterAsync(RedisKey key, RedisValue pivot, RedisValue value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long ListInsertBefore(RedisKey key, RedisValue pivot, RedisValue value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> ListInsertBeforeAsync(RedisKey key, RedisValue pivot, RedisValue value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public RedisValue ListLeftPop(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<RedisValue> ListLeftPopAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long ListLeftPush(RedisKey key, RedisValue value, When when = When.Always, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long ListLeftPush(RedisKey key, RedisValue[] values, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> ListLeftPushAsync(RedisKey key, RedisValue value, When when = When.Always, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> ListLeftPushAsync(RedisKey key, RedisValue[] values, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long ListLength(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> ListLengthAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public RedisValue[] ListRange(RedisKey key, long start = 0, long stop = -1, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<RedisValue[]> ListRangeAsync(RedisKey key, long start = 0, long stop = -1, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long ListRemove(RedisKey key, RedisValue value, long count = 0, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> ListRemoveAsync(RedisKey key, RedisValue value, long count = 0, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public RedisValue ListRightPop(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<RedisValue> ListRightPopAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public RedisValue ListRightPopLeftPush(RedisKey source, RedisKey destination, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<RedisValue> ListRightPopLeftPushAsync(RedisKey source, RedisKey destination, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long ListRightPush(RedisKey key, RedisValue value, When when = When.Always, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long ListRightPush(RedisKey key, RedisValue[] values, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> ListRightPushAsync(RedisKey key, RedisValue value, When when = When.Always, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> ListRightPushAsync(RedisKey key, RedisValue[] values, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public void ListSetByIndex(RedisKey key, long index, RedisValue value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task ListSetByIndexAsync(RedisKey key, long index, RedisValue value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public void ListTrim(RedisKey key, long start, long stop, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task ListTrimAsync(RedisKey key, long start, long stop, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public bool LockExtend(RedisKey key, RedisValue value, TimeSpan expiry, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<bool> LockExtendAsync(RedisKey key, RedisValue value, TimeSpan expiry, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public RedisValue LockQuery(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<RedisValue> LockQueryAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public bool LockRelease(RedisKey key, RedisValue value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<bool> LockReleaseAsync(RedisKey key, RedisValue value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public bool LockTake(RedisKey key, RedisValue value, TimeSpan expiry, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<bool> LockTakeAsync(RedisKey key, RedisValue value, TimeSpan expiry, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public TimeSpan Ping(CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<TimeSpan> PingAsync(CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long Publish(RedisChannel channel, RedisValue message, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> PublishAsync(RedisChannel channel, RedisValue message, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public RedisResult ScriptEvaluate(string script, RedisKey[] keys = null, RedisValue[] values = null, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public RedisResult ScriptEvaluate(byte[] hash, RedisKey[] keys = null, RedisValue[] values = null, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public RedisResult ScriptEvaluate(LuaScript script, object parameters = null, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public RedisResult ScriptEvaluate(LoadedLuaScript script, object parameters = null, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<RedisResult> ScriptEvaluateAsync(string script, RedisKey[] keys = null, RedisValue[] values = null, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<RedisResult> ScriptEvaluateAsync(byte[] hash, RedisKey[] keys = null, RedisValue[] values = null, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<RedisResult> ScriptEvaluateAsync(LuaScript script, object parameters = null, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<RedisResult> ScriptEvaluateAsync(LoadedLuaScript script, object parameters = null, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public bool SetAdd(RedisKey key, RedisValue value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long SetAdd(RedisKey key, RedisValue[] values, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<bool> SetAddAsync(RedisKey key, RedisValue value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> SetAddAsync(RedisKey key, RedisValue[] values, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public RedisValue[] SetCombine(SetOperation operation, RedisKey first, RedisKey second, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public RedisValue[] SetCombine(SetOperation operation, RedisKey[] keys, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long SetCombineAndStore(SetOperation operation, RedisKey destination, RedisKey first, RedisKey second, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long SetCombineAndStore(SetOperation operation, RedisKey destination, RedisKey[] keys, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> SetCombineAndStoreAsync(SetOperation operation, RedisKey destination, RedisKey first, RedisKey second, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> SetCombineAndStoreAsync(SetOperation operation, RedisKey destination, RedisKey[] keys, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<RedisValue[]> SetCombineAsync(SetOperation operation, RedisKey first, RedisKey second, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<RedisValue[]> SetCombineAsync(SetOperation operation, RedisKey[] keys, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public bool SetContains(RedisKey key, RedisValue value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<bool> SetContainsAsync(RedisKey key, RedisValue value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long SetLength(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> SetLengthAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public RedisValue[] SetMembers(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<RedisValue[]> SetMembersAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public bool SetMove(RedisKey source, RedisKey destination, RedisValue value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<bool> SetMoveAsync(RedisKey source, RedisKey destination, RedisValue value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public RedisValue SetPop(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public RedisValue[] SetPop(RedisKey key, long count, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<RedisValue> SetPopAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<RedisValue[]> SetPopAsync(RedisKey key, long count, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public RedisValue SetRandomMember(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<RedisValue> SetRandomMemberAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public RedisValue[] SetRandomMembers(RedisKey key, long count, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<RedisValue[]> SetRandomMembersAsync(RedisKey key, long count, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public bool SetRemove(RedisKey key, RedisValue value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long SetRemove(RedisKey key, RedisValue[] values, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<bool> SetRemoveAsync(RedisKey key, RedisValue value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> SetRemoveAsync(RedisKey key, RedisValue[] values, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public IEnumerable<RedisValue> SetScan(RedisKey key, RedisValue pattern, int pageSize, CommandFlags flags)
        {
            throw new NotSupportedException();
        }

        public IEnumerable<RedisValue> SetScan(RedisKey key, RedisValue pattern = default, int pageSize = 10, long cursor = 0, int pageOffset = 0, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public RedisValue[] Sort(RedisKey key,
            long skip = 0,
            long take = -1,
            Order order = Order.Ascending,
            SortType sortType = SortType.Numeric,
            RedisValue by = default,
            RedisValue[] get = null,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long SortAndStore(RedisKey destination,
            RedisKey key,
            long skip = 0,
            long take = -1,
            Order order = Order.Ascending,
            SortType sortType = SortType.Numeric,
            RedisValue by = default,
            RedisValue[] get = null,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> SortAndStoreAsync(RedisKey destination,
            RedisKey key,
            long skip = 0,
            long take = -1,
            Order order = Order.Ascending,
            SortType sortType = SortType.Numeric,
            RedisValue by = default,
            RedisValue[] get = null,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<RedisValue[]> SortAsync(RedisKey key,
            long skip = 0,
            long take = -1,
            Order order = Order.Ascending,
            SortType sortType = SortType.Numeric,
            RedisValue by = default,
            RedisValue[] get = null,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public bool SortedSetAdd(RedisKey key, RedisValue member, double score, CommandFlags flags)
        {
            throw new NotSupportedException();
        }

        public bool SortedSetAdd(RedisKey key, RedisValue member, double score, When when = When.Always, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long SortedSetAdd(RedisKey key, SortedSetEntry[] values, CommandFlags flags)
        {
            throw new NotSupportedException();
        }

        public long SortedSetAdd(RedisKey key, SortedSetEntry[] values, When when = When.Always, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<bool> SortedSetAddAsync(RedisKey key, RedisValue member, double score, CommandFlags flags)
        {
            throw new NotSupportedException();
        }

        public Task<bool> SortedSetAddAsync(RedisKey key, RedisValue member, double score, When when = When.Always, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> SortedSetAddAsync(RedisKey key, SortedSetEntry[] values, CommandFlags flags)
        {
            throw new NotSupportedException();
        }

        public Task<long> SortedSetAddAsync(RedisKey key, SortedSetEntry[] values, When when = When.Always, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long SortedSetCombineAndStore(SetOperation operation, RedisKey destination, RedisKey first, RedisKey second, Aggregate aggregate = Aggregate.Sum, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long SortedSetCombineAndStore(SetOperation operation,
            RedisKey destination,
            RedisKey[] keys,
            double[] weights = null,
            Aggregate aggregate = Aggregate.Sum,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> SortedSetCombineAndStoreAsync(SetOperation operation,
            RedisKey destination,
            RedisKey first,
            RedisKey second,
            Aggregate aggregate = Aggregate.Sum,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> SortedSetCombineAndStoreAsync(SetOperation operation,
            RedisKey destination,
            RedisKey[] keys,
            double[] weights = null,
            Aggregate aggregate = Aggregate.Sum,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public double SortedSetDecrement(RedisKey key, RedisValue member, double value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<double> SortedSetDecrementAsync(RedisKey key, RedisValue member, double value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public double SortedSetIncrement(RedisKey key, RedisValue member, double value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<double> SortedSetIncrementAsync(RedisKey key, RedisValue member, double value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long SortedSetLength(RedisKey key, double min = double.NegativeInfinity, double max = double.PositiveInfinity, Exclude exclude = Exclude.None, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> SortedSetLengthAsync(RedisKey key,
            double min = double.NegativeInfinity,
            double max = double.PositiveInfinity,
            Exclude exclude = Exclude.None,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long SortedSetLengthByValue(RedisKey key, RedisValue min, RedisValue max, Exclude exclude = Exclude.None, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> SortedSetLengthByValueAsync(RedisKey key, RedisValue min, RedisValue max, Exclude exclude = Exclude.None, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public SortedSetEntry? SortedSetPop(RedisKey key, Order order = Order.Ascending, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public SortedSetEntry[] SortedSetPop(RedisKey key, long count, Order order = Order.Ascending, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<SortedSetEntry?> SortedSetPopAsync(RedisKey key, Order order = Order.Ascending, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<SortedSetEntry[]> SortedSetPopAsync(RedisKey key, long count, Order order = Order.Ascending, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public RedisValue[] SortedSetRangeByRank(RedisKey key, long start = 0, long stop = -1, Order order = Order.Ascending, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<RedisValue[]> SortedSetRangeByRankAsync(RedisKey key, long start = 0, long stop = -1, Order order = Order.Ascending, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public SortedSetEntry[] SortedSetRangeByRankWithScores(RedisKey key, long start = 0, long stop = -1, Order order = Order.Ascending, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<SortedSetEntry[]> SortedSetRangeByRankWithScoresAsync(RedisKey key, long start = 0, long stop = -1, Order order = Order.Ascending, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public RedisValue[] SortedSetRangeByScore(RedisKey key,
            double start = double.NegativeInfinity,
            double stop = double.PositiveInfinity,
            Exclude exclude = Exclude.None,
            Order order = Order.Ascending,
            long skip = 0,
            long take = -1,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<RedisValue[]> SortedSetRangeByScoreAsync(RedisKey key,
            double start = double.NegativeInfinity,
            double stop = double.PositiveInfinity,
            Exclude exclude = Exclude.None,
            Order order = Order.Ascending,
            long skip = 0,
            long take = -1,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public SortedSetEntry[] SortedSetRangeByScoreWithScores(RedisKey key,
            double start = double.NegativeInfinity,
            double stop = double.PositiveInfinity,
            Exclude exclude = Exclude.None,
            Order order = Order.Ascending,
            long skip = 0,
            long take = -1,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<SortedSetEntry[]> SortedSetRangeByScoreWithScoresAsync(RedisKey key,
            double start = double.NegativeInfinity,
            double stop = double.PositiveInfinity,
            Exclude exclude = Exclude.None,
            Order order = Order.Ascending,
            long skip = 0,
            long take = -1,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public RedisValue[] SortedSetRangeByValue(RedisKey key, RedisValue min, RedisValue max, Exclude exclude, long skip, long take = -1, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public RedisValue[] SortedSetRangeByValue(RedisKey key,
            RedisValue min = default,
            RedisValue max = default,
            Exclude exclude = Exclude.None,
            Order order = Order.Ascending,
            long skip = 0,
            long take = -1,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<RedisValue[]> SortedSetRangeByValueAsync(RedisKey key, RedisValue min, RedisValue max, Exclude exclude, long skip, long take = -1, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<RedisValue[]> SortedSetRangeByValueAsync(RedisKey key,
            RedisValue min = default,
            RedisValue max = default,
            Exclude exclude = Exclude.None,
            Order order = Order.Ascending,
            long skip = 0,
            long take = -1,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long? SortedSetRank(RedisKey key, RedisValue member, Order order = Order.Ascending, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long?> SortedSetRankAsync(RedisKey key, RedisValue member, Order order = Order.Ascending, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public bool SortedSetRemove(RedisKey key, RedisValue member, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long SortedSetRemove(RedisKey key, RedisValue[] members, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<bool> SortedSetRemoveAsync(RedisKey key, RedisValue member, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> SortedSetRemoveAsync(RedisKey key, RedisValue[] members, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long SortedSetRemoveRangeByRank(RedisKey key, long start, long stop, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> SortedSetRemoveRangeByRankAsync(RedisKey key, long start, long stop, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long SortedSetRemoveRangeByScore(RedisKey key, double start, double stop, Exclude exclude = Exclude.None, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> SortedSetRemoveRangeByScoreAsync(RedisKey key, double start, double stop, Exclude exclude = Exclude.None, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long SortedSetRemoveRangeByValue(RedisKey key, RedisValue min, RedisValue max, Exclude exclude = Exclude.None, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> SortedSetRemoveRangeByValueAsync(RedisKey key, RedisValue min, RedisValue max, Exclude exclude = Exclude.None, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public IEnumerable<SortedSetEntry> SortedSetScan(RedisKey key, RedisValue pattern, int pageSize, CommandFlags flags)
        {
            throw new NotSupportedException();
        }

        public IEnumerable<SortedSetEntry> SortedSetScan(RedisKey key, RedisValue pattern = default, int pageSize = 10, long cursor = 0, int pageOffset = 0, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public double? SortedSetScore(RedisKey key, RedisValue member, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<double?> SortedSetScoreAsync(RedisKey key, RedisValue member, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long StreamAcknowledge(RedisKey key, RedisValue groupName, RedisValue messageId, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long StreamAcknowledge(RedisKey key, RedisValue groupName, RedisValue[] messageIds, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> StreamAcknowledgeAsync(RedisKey key, RedisValue groupName, RedisValue messageId, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> StreamAcknowledgeAsync(RedisKey key, RedisValue groupName, RedisValue[] messageIds, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public RedisValue StreamAdd(RedisKey key,
            RedisValue streamField,
            RedisValue streamValue,
            RedisValue? messageId = null,
            int? maxLength = null,
            bool useApproximateMaxLength = false,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public RedisValue StreamAdd(RedisKey key,
            NameValueEntry[] streamPairs,
            RedisValue? messageId = null,
            int? maxLength = null,
            bool useApproximateMaxLength = false,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<RedisValue> StreamAddAsync(RedisKey key,
            RedisValue streamField,
            RedisValue streamValue,
            RedisValue? messageId = null,
            int? maxLength = null,
            bool useApproximateMaxLength = false,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<RedisValue> StreamAddAsync(RedisKey key,
            NameValueEntry[] streamPairs,
            RedisValue? messageId = null,
            int? maxLength = null,
            bool useApproximateMaxLength = false,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public StreamEntry[] StreamClaim(RedisKey key, RedisValue consumerGroup, RedisValue claimingConsumer, long minIdleTimeInMs, RedisValue[] messageIds, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<StreamEntry[]> StreamClaimAsync(RedisKey key,
            RedisValue consumerGroup,
            RedisValue claimingConsumer,
            long minIdleTimeInMs,
            RedisValue[] messageIds,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public RedisValue[] StreamClaimIdsOnly(RedisKey key,
            RedisValue consumerGroup,
            RedisValue claimingConsumer,
            long minIdleTimeInMs,
            RedisValue[] messageIds,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<RedisValue[]> StreamClaimIdsOnlyAsync(RedisKey key,
            RedisValue consumerGroup,
            RedisValue claimingConsumer,
            long minIdleTimeInMs,
            RedisValue[] messageIds,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public bool StreamConsumerGroupSetPosition(RedisKey key, RedisValue groupName, RedisValue position, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<bool> StreamConsumerGroupSetPositionAsync(RedisKey key, RedisValue groupName, RedisValue position, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public StreamConsumerInfo[] StreamConsumerInfo(RedisKey key, RedisValue groupName, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<StreamConsumerInfo[]> StreamConsumerInfoAsync(RedisKey key, RedisValue groupName, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public bool StreamCreateConsumerGroup(RedisKey key, RedisValue groupName, RedisValue? position = null, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<bool> StreamCreateConsumerGroupAsync(RedisKey key, RedisValue groupName, RedisValue? position = null, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long StreamDelete(RedisKey key, RedisValue[] messageIds, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> StreamDeleteAsync(RedisKey key, RedisValue[] messageIds, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long StreamDeleteConsumer(RedisKey key, RedisValue groupName, RedisValue consumerName, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> StreamDeleteConsumerAsync(RedisKey key, RedisValue groupName, RedisValue consumerName, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public bool StreamDeleteConsumerGroup(RedisKey key, RedisValue groupName, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<bool> StreamDeleteConsumerGroupAsync(RedisKey key, RedisValue groupName, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public StreamGroupInfo[] StreamGroupInfo(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<StreamGroupInfo[]> StreamGroupInfoAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public StreamInfo StreamInfo(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<StreamInfo> StreamInfoAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long StreamLength(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> StreamLengthAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public StreamPendingInfo StreamPending(RedisKey key, RedisValue groupName, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<StreamPendingInfo> StreamPendingAsync(RedisKey key, RedisValue groupName, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public StreamPendingMessageInfo[] StreamPendingMessages(RedisKey key,
            RedisValue groupName,
            int count,
            RedisValue consumerName,
            RedisValue? minId = null,
            RedisValue? maxId = null,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<StreamPendingMessageInfo[]> StreamPendingMessagesAsync(RedisKey key,
            RedisValue groupName,
            int count,
            RedisValue consumerName,
            RedisValue? minId = null,
            RedisValue? maxId = null,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public StreamEntry[] StreamRange(RedisKey key,
            RedisValue? minId = null,
            RedisValue? maxId = null,
            int? count = null,
            Order messageOrder = Order.Ascending,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<StreamEntry[]> StreamRangeAsync(RedisKey key,
            RedisValue? minId = null,
            RedisValue? maxId = null,
            int? count = null,
            Order messageOrder = Order.Ascending,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public StreamEntry[] StreamRead(RedisKey key, RedisValue position, int? count = null, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public RedisStream[] StreamRead(StreamPosition[] streamPositions, int? countPerStream = null, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<StreamEntry[]> StreamReadAsync(RedisKey key, RedisValue position, int? count = null, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<RedisStream[]> StreamReadAsync(StreamPosition[] streamPositions, int? countPerStream = null, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public StreamEntry[] StreamReadGroup(RedisKey key, RedisValue groupName, RedisValue consumerName, RedisValue? position = null, int? count = null, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public RedisStream[] StreamReadGroup(StreamPosition[] streamPositions, RedisValue groupName, RedisValue consumerName, int? countPerStream = null, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<StreamEntry[]> StreamReadGroupAsync(RedisKey key,
            RedisValue groupName,
            RedisValue consumerName,
            RedisValue? position = null,
            int? count = null,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<RedisStream[]> StreamReadGroupAsync(StreamPosition[] streamPositions,
            RedisValue groupName,
            RedisValue consumerName,
            int? countPerStream = null,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long StreamTrim(RedisKey key, int maxLength, bool useApproximateMaxLength = false, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> StreamTrimAsync(RedisKey key, int maxLength, bool useApproximateMaxLength = false, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long StringAppend(RedisKey key, RedisValue value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> StringAppendAsync(RedisKey key, RedisValue value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long StringBitCount(RedisKey key, long start = 0, long end = -1, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> StringBitCountAsync(RedisKey key, long start = 0, long end = -1, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long StringBitOperation(Bitwise operation, RedisKey destination, RedisKey first, RedisKey second = default, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long StringBitOperation(Bitwise operation, RedisKey destination, RedisKey[] keys, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> StringBitOperationAsync(Bitwise operation, RedisKey destination, RedisKey first, RedisKey second = default, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> StringBitOperationAsync(Bitwise operation, RedisKey destination, RedisKey[] keys, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long StringBitPosition(RedisKey key, bool bit, long start = 0, long end = -1, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> StringBitPositionAsync(RedisKey key, bool bit, long start = 0, long end = -1, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long StringDecrement(RedisKey key, long value = 1, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public double StringDecrement(RedisKey key, double value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> StringDecrementAsync(RedisKey key, long value = 1, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<double> StringDecrementAsync(RedisKey key, double value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public RedisValue StringGet(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public RedisValue[] StringGet(RedisKey[] keys, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public bool StringGetBit(RedisKey key, long offset, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<bool> StringGetBitAsync(RedisKey key, long offset, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Lease<byte> StringGetLease(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<Lease<byte>> StringGetLeaseAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public RedisValue StringGetRange(RedisKey key, long start, long end, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<RedisValue> StringGetRangeAsync(RedisKey key, long start, long end, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public RedisValue StringGetSet(RedisKey key, RedisValue value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<RedisValue> StringGetSetAsync(RedisKey key, RedisValue value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public RedisValueWithExpiry StringGetWithExpiry(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<RedisValueWithExpiry> StringGetWithExpiryAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long StringIncrement(RedisKey key, long value = 1, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public double StringIncrement(RedisKey key, double value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> StringIncrementAsync(RedisKey key, long value = 1, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<double> StringIncrementAsync(RedisKey key, double value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long StringLength(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> StringLengthAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public bool StringSet(RedisKey key, RedisValue value, TimeSpan? expiry = null, When when = When.Always, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public bool StringSet(KeyValuePair<RedisKey, RedisValue>[] values, When when = When.Always, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<bool> StringSetAsync(KeyValuePair<RedisKey, RedisValue>[] values, When when = When.Always, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<bool> StringSetAsync(RedisKey key, RedisValue value, TimeSpan? expiry = null, When when = When.Always, CommandFlags flags = CommandFlags.None)
        {
            return Task.FromResult(true);
        }

        public bool StringSetBit(RedisKey key, long offset, bool bit, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<bool> StringSetBitAsync(RedisKey key, long offset, bool bit, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public RedisValue StringSetRange(RedisKey key, long offset, RedisValue value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<RedisValue> StringSetRangeAsync(RedisKey key, long offset, RedisValue value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public bool TryWait(Task task)
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

        public long HashStringLength(RedisKey key, RedisValue hashField, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long ListLeftPush(RedisKey key, RedisValue[] values, When when = When.Always, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long ListRightPush(RedisKey key, RedisValue[] values, When when = When.Always, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public bool StreamCreateConsumerGroup(RedisKey key, RedisValue groupName, RedisValue? position = null, bool createStream = true, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public StreamEntry[] StreamReadGroup(
            RedisKey key,
            RedisValue groupName,
            RedisValue consumerName,
            RedisValue? position = null,
            int? count = null,
            bool noAck = false,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public RedisStream[] StreamReadGroup(
            StreamPosition[] streamPositions,
            RedisValue groupName,
            RedisValue consumerName,
            int? countPerStream = null,
            bool noAck = false,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public bool KeyTouch(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public long KeyTouch(RedisKey[] keys, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public IAsyncEnumerable<HashEntry> HashScanAsync(RedisKey key, RedisValue pattern = default, int pageSize = 250, long cursor = 0, int pageOffset = 0, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> HashStringLengthAsync(RedisKey key, RedisValue hashField, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> ListLeftPushAsync(RedisKey key, RedisValue[] values, When when = When.Always, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> ListRightPushAsync(RedisKey key, RedisValue[] values, When when = When.Always, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public IAsyncEnumerable<RedisValue> SetScanAsync(RedisKey key, RedisValue pattern = default, int pageSize = 250, long cursor = 0, int pageOffset = 0, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public IAsyncEnumerable<SortedSetEntry> SortedSetScanAsync(
            RedisKey key,
            RedisValue pattern = default,
            int pageSize = 250,
            long cursor = 0,
            int pageOffset = 0,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<bool> StreamCreateConsumerGroupAsync(RedisKey key, RedisValue groupName, RedisValue? position = null, bool createStream = true, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<StreamEntry[]> StreamReadGroupAsync(
            RedisKey key,
            RedisValue groupName,
            RedisValue consumerName,
            RedisValue? position = null,
            int? count = null,
            bool noAck = false,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<RedisStream[]> StreamReadGroupAsync(
            StreamPosition[] streamPositions,
            RedisValue groupName,
            RedisValue consumerName,
            int? countPerStream = null,
            bool noAck = false,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<bool> KeyTouchAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }

        public Task<long> KeyTouchAsync(RedisKey[] keys, CommandFlags flags = CommandFlags.None)
        {
            throw new NotSupportedException();
        }
    }
}
