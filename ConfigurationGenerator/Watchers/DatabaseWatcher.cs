using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ConfigurationGenerator.Watchers.Abstract;

namespace ConfigurationGenerator.Watchers
{
    public class DatabaseWatcher : IDatabaseWatcher
    {
        private const int databaseRefreshTimeoutDefault = 5000;

        private readonly string databaseConnectionString;

        private readonly string databaseName;

        private readonly int databaseRefreshTimeout;

        private readonly string databaseSettingsTable;

        private Dictionary<string, string> collection = new Dictionary<string, string>();

        public DatabaseWatcher(
            bool start, 
            string databaseName, 
            string databaseSettingsTable, 
            int databaseRefreshTimeout = databaseRefreshTimeoutDefault)
        {
            if (!start)
            {
                return;
            }

            this.databaseName = databaseName;
            this.databaseSettingsTable = databaseSettingsTable;
            this.databaseRefreshTimeout = databaseRefreshTimeout;
            this.databaseConnectionString = string.Empty;

            // ConfigProviderTool.DecryptConnectionString(this.databaseName);
            this.collection = this.GetDbSettings();

            Task.Factory.StartNew(this.RegisterForChanges);
        }

        public event EventHandler<EventArgs> SettingsChanged;

        public Dictionary<string, string> Collection
        {
            get
            {
                return this.collection;
            }
        }

        public void OnChanged(object source, EventArgs e)
        {
            if (this.SettingsChanged != null)
            {
                this.SettingsChanged(source, e);
            }
        }

        private Dictionary<string, string> GetDbSettings()
        {
            Dictionary<string, string> col = new Dictionary<string, string>();

            try
            {
                using (SqlConnection conn = new SqlConnection(this.databaseConnectionString))
                {
                    string sql = "select * from " + this.databaseSettingsTable;
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string key = reader["Key"].ToString();
                            string value = reader["Value"].ToString();
                            col.Add(key, value);
                        }
                    }

                    conn.Close();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Could not connecto to settings database", ex);
            }

            return col;
        }

        private void RegisterForChanges()
        {
            while (true)
            {
                // Get settings from db
                Dictionary<string, string> col = this.GetDbSettings();

                // Check db settings and current are equal
                bool equal = this.Collection.Keys.Count() == col.Keys.Count()
                             && this.Collection.Keys.All(
                                 k => col.Keys.Contains(k) && Equals(col[k], this.Collection[k]));

                if (!equal)
                {
                    this.OnChanged(this, new EventArgs());

                    // update current collection
                    this.collection = col;
                }

                Thread.Sleep(this.databaseRefreshTimeout);
            }
        }
    }
}