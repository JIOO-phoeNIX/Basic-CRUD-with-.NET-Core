using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Task1.DataAccess.Models;

namespace Task1.DataAccess.Repository
{
    public class ItemsRepository
    {
        private readonly Task1DbContext dbContext;

        public ItemsRepository(Task1DbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Items> GetAll()
        {
            return dbContext.Items.ToList();
        }

        public async Task Create(Items item)
        {
            dbContext.Add(item);
            await dbContext.SaveChangesAsync();
        }

        public async Task<Items> Get(int? id)
        {
            return await dbContext.Items.FindAsync(id);
        }

        public async Task Edit(Items item)
        {
            dbContext.Update(item);           
            await dbContext.SaveChangesAsync();
        }

        public async Task Delete(Items item)
        {
            dbContext.Remove(item);
            await dbContext.SaveChangesAsync();
        }
    }
}
