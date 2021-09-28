using DIO.AvaCloud.Domain;
using DIO.AvaCloud.Domain.Interfaces;
using DIO.AvaCloud.Infra.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DIO.AvaCloud.Infra.Repository
{
    public class RepositorySQL<T> : IRepository<T> where T : EntityBase
    {
        private readonly AvaCloudDB _context;

        internal readonly DbSet<T> _tables;

        public RepositorySQL(AvaCloudDB context)
        {
            _context = context;
            _tables = _context.Set<T>();
        }

        public async Task<int> AddAsync(T entity)
        {
            _tables.Add(entity);

            await _context.SaveChangesAsync();

            return entity.Id;
        }

        public async Task<int> CountAsync()
        {
            return await _tables.CountAsync(); 
        }

        public async Task DeleteAsync(T entity)
        {
            _tables.Remove(entity);

            await _context.SaveChangesAsync();
        }

        public async Task EditAsync(T entity)
        {
            _tables.Update(entity);

            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _tables.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _tables.FindAsync(id);
        }
    }
}
