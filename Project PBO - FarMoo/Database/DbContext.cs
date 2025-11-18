using DotNetEnv;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PBO___FarMoo.Database
{
    public class DbContext
    {
        private string _dbHost;
        private string _dbPort;
        private string _dbUser;
        private string _dbPassword;
        private string _dbName;
        private string _sslMode;
        private string _channelBinding;

        public string connStr;
        public NpgsqlConnection Connection;

        public DbContext()
        {
            Env.Load();

            _dbHost = Environment.GetEnvironmentVariable("DB_HOST");
            _dbPort = Environment.GetEnvironmentVariable("DB_PORT");
            _dbUser = Environment.GetEnvironmentVariable("DB_USER");
            _dbPassword = Environment.GetEnvironmentVariable("DB_PASSWORD");
            _dbName = Environment.GetEnvironmentVariable("DB_NAME");
            _sslMode = Environment.GetEnvironmentVariable("SSL_MODE") ?? "Disable";
            _channelBinding = Environment.GetEnvironmentVariable("CHANNEL_BINDING") ?? "Disable";

            connStr =
                $"Host={_dbHost};" +
                $"Port={_dbPort};" +
                $"Username={_dbUser};" +
                $"Password={_dbPassword};" +
                $"Database={_dbName};" +
                $"SSL Mode={_sslMode};" +
                $"ChannelBinding={_channelBinding};";

            Connection = new NpgsqlConnection(connStr);
        }

        public void Open()
        {
            if (Connection.State != System.Data.ConnectionState.Open)
                Connection.Open();
        }

        public void Close()
        {
            if (Connection.State != System.Data.ConnectionState.Closed)
                Connection.Close();
        }
    }
}