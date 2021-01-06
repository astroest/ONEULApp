using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ONEULApp.Data
{
    public class SqliteOneulRepository : OneulRepository
    {
        private SQLiteAsyncConnection _connection;

        public async Task AddorUpdateOneul(OneulDB oneuldb)
        {
            if(oneuldb.ID != 0)
            {
                _ = await _connection.UpdateAsync(oneuldb);
            }
            else
            {
                _ = await _connection.InsertAsync(oneuldb);
            }
        }

        public Task<List<OneulDB>> GetOneuls()
        {
            return _connection.Table<OneulDB>().ToListAsync();
        }

        public async Task Initialize()
        {
            if (_connection != null) return;

            _connection = new SQLiteAsyncConnection(
                Path.Combine(Xamarin.Essentials.FileSystem.AppDataDirectory, "oneul.db"));

            await _connection.CreateTableAsync<OneulDB>();
        }
    }
}
