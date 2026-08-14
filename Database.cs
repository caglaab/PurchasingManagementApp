using System;
using System.IO;
using Microsoft.Data.Sqlite;

namespace PurchasingManagementApp
{
    public static class Database
    {
        private static readonly string appDataFolder =
            Path.Combine(
                Environment.GetFolderPath(
                    Environment.SpecialFolder.LocalApplicationData),
                "PurchasingManagementApp");

        public static readonly string DatabasePath =
            Path.Combine(appDataFolder, "Purchases.db");

        public static readonly string ConnectionString =
            $"Data Source={DatabasePath}";

        public static void Initialize()
        {
            Directory.CreateDirectory(appDataFolder);

            string oldDatabasePath = Path.Combine(
                AppContext.BaseDirectory,
                "Purchases.db");

            if (!File.Exists(DatabasePath) && File.Exists(oldDatabasePath))
            {
                File.Copy(oldDatabasePath, DatabasePath);
            }

            using (var connection = new SqliteConnection(ConnectionString))
            {
                connection.Open();

                string createTableQuery = @"
            CREATE TABLE IF NOT EXISTS Purchases
            (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                ItemCode TEXT NOT NULL,
                Supplier TEXT NOT NULL,
                Quantity REAL NOT NULL,
                UnitPrice REAL NOT NULL,
                PurchaseDate TEXT NOT NULL,
                TotalPrice REAL NOT NULL
            )";

                using (var command = new SqliteCommand(createTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}