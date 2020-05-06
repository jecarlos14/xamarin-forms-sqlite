using SQLite.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SQLite.Data
{
    public class DBPerson : DataBase
    {
        public DBPerson()
        {
            database.CreateTableAsync<PersonModel>().Wait();
        }

        public Task<List<PersonModel>> GetItemsAsync()
        {
            return database.Table<PersonModel>().ToListAsync();
        }

        public Task<PersonModel> GetAsync(int id)
        {
            return database.Table<PersonModel>().FirstOrDefaultAsync(i => i.Id == id);
        }

        public Task<int> Save(PersonModel item)
        {
            if (item.Id != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }

        public Task<int> Delete(PersonModel item)
        {
            return database.DeleteAsync(item);
        }
    }
}
