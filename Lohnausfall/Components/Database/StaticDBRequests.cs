using Lohnausfall.Components.Models;
using Microsoft.Data.Sqlite;

namespace Portfolio.Components.Database
{
    public static class StaticDBRequests
    {
        private static readonly string _dataSource = @$"Data Source={AppDomain.CurrentDomain.BaseDirectory}fw_members.db;";

        public static async Task<List<FWMemberModel>> GetAllMembersAsync()
        {
            List<FWMemberModel> members = [];

            try
            {
                var sqlCon = new SqliteConnection(_dataSource);
                sqlCon.Open();

                var command = sqlCon.CreateCommand();
                command.CommandText = @"SELECT * from members;";

                using var reader = await command.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                    members.Add(new(reader.GetInt32(0), reader.GetString(1), reader.GetString(2)));
                
                await reader.CloseAsync();
                await reader.DisposeAsync();
            }
            catch (Exception e) 
            {
            }

            return members;
        }
    }
}