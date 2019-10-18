namespace Hollysys.Common
{
    public static class DatabaseConfig
    {

        private static readonly string SqliteConnection =
                AppSettings.ReadContent("AppSettings", "Sqlite", "SqliteConnection");

        private static readonly bool IsSqliteEnabled =
                AppSettings.ReadContent("AppSettings", "Sqlite", "Enabled").ObjToBool();

        private static readonly string SqlServerConnection =
                AppSettings.ReadContent("AppSettings", "SqlServer", "SqlServerConnection");

        private static readonly bool IsSqlServerEnabled =
                AppSettings.ReadContent("AppSettings", "SqlServer", "Enabled").ObjToBool();

        private static readonly string MySqlConnection =
                AppSettings.ReadContent("AppSettings", "MySql", "MySqlConnection");

        private static readonly bool IsMySqlEnabled =
                AppSettings.ReadContent("AppSettings", "MySql", "Enabled").ObjToBool();

        private static readonly string OracleConnection =
                AppSettings.ReadContent("AppSettings", "Oracle", "OracleConnection");

        private static readonly bool IsOracleEnabled =
                AppSettings.ReadContent("AppSettings", "Oracle", "Enabled").ObjToBool();

        public static DataBaseType DataBaseType = DataBaseType.SqlServer;

        public static string ConnectionString => InitConnectString();

        private static string InitConnectString()
        {
            if (IsSqliteEnabled)
            {
                DataBaseType = DataBaseType.Sqlite;
                return SqliteConnection;
            }

            if (IsSqlServerEnabled)
            {
                DataBaseType = DataBaseType.SqlServer;
                return SqliteConnection;
            }

            if (IsMySqlEnabled)
            {
                DataBaseType = DataBaseType.MySql;
                return MySqlConnection;
            }

            if (IsOracleEnabled)
            {
                DataBaseType = DataBaseType.Oracle;
                return OracleConnection;
            }

            return string.Empty;
        }
    }
}