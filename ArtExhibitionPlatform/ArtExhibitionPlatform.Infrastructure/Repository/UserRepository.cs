﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtExhibitionPlatform.Infrastructure.Context;
using ArtexibitionPlatform.Domain;
using Microsoft.EntityFrameworkCore;

namespace ArtExhibitionPlatform.Infrastructure.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ArtExhibitionDbContext _context;

        public UserRepository(ArtExhibitionDbContext context)
        {
            _context = context;
        }

        public async Task<User> GetByIdAsync(int userId)
        {
            return await _context.Users.FindAsync(userId);
        }

        public async Task<User> GetByUsernameAsync(string username)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Username == username);
        }

        public async Task AddAsync(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(User user)
        {
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int userId)
        {
            var user = await _context.Users.FindAsync(userId);
            if (user != null)
            {
                _context.Users.Remove(user);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            return await _context.Users.ToListAsync();
        }




    }

    public interface IUserRepository
    {
    }
}
