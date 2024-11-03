﻿using Microsoft.EntityFrameworkCore;
using UserBankApi.Data;
using UserBankApi.Models.Entities;

namespace Infrastructure.Repository
{
    public class UserRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<UserEntity> _entities;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
            _entities = _context.Set<UserEntity>();
        }

        public async Task<UserEntity> SaveAsync(UserEntity userEntity)
        {
            _entities.Add(userEntity);
            await _context.SaveChangesAsync();
            return userEntity;
        }
    }
}
