namespace DbSqlite
{
    public class FreeSqlHelper
    {
        private static IFreeSql fsql;
        public static IFreeSql FSql
        {
            get
            {
                if (fsql != null) return fsql;
                System.Threading.Interlocked.CompareExchange(ref fsql, Builder(), null);
                return fsql;
            }
        }

        private static string ValueBase => $"Data Source=|DataDirectory|\\sys.domain.dll;";
        private static string ValuePublic => $"{ValueBase} Pooling=true;Min Pool Size=1";
        //internal static string ValuePublic => $"{ValueBase} Attachs={SqliteCommon.DbName}; Pooling=true;Min Pool Size=1";
        private static IFreeSql Builder()
        {
            var freeSqlBuilder = new FreeSql.FreeSqlBuilder()
                        .UseConnectionString(FreeSql.DataType.Sqlite, ValuePublic)
                        .UseAutoSyncStructure(true)
                        .UseLazyLoading(false)
                        .UseMonitorCommand(default, executed: (cmd, traceLog) =>
                        {
                            Console.WriteLine($"com>>{traceLog}\r\n");//监听所有命令
                        })
                        .UseNoneCommandParameter(true);
            return freeSqlBuilder.Build();
        }
    }
}
