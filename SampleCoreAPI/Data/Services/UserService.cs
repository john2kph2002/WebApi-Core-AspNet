using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SampleCoreAPI.Data.ViewModels;
using SampleCoreAPI.Models;

namespace SampleCoreAPI.Data.Services
{
    public class UserService : IUserService
    {
        private PRGPeraMainContext _dbcontext;
        public UserService(PRGPeraMainContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<int> AddUser(UserVM user)
        {
            var _user = new UserAccount()
            {
                Username = user.Username,
                Email = user.Email,
                Active = user.Active,
                CreatedOn = DateTime.Now
            };

            _dbcontext.Add(_user);
            await _dbcontext.SaveChangesAsync();

            return _user.Id;
        }
        public async Task UpdateUser(int id, UserVM user)
        {
            //var _user = await _dbcontext.UserAccount.FindAsync(id);
            //if(_user != null)
            //{
            //    _user.Username = user.Username;
            //    _user.Email = user.Email;
            //    _user.UpdatedOn = DateTime.Now;

            //    await _dbcontext.SaveChangesAsync();
            //};

            var _user = new UserAccount()
            {
                Id = user.Id,
                Username = user.Username,
                Email = user.Email,
                UpdatedOn = DateTime.Now
        };
            _dbcontext.Update(_user);
            await _dbcontext.SaveChangesAsync();
        }

        public async Task<List<UserAccount>> GetUsers() 
        {
            var rec = await _dbcontext.UserAccount.Select(x => new UserAccount()
            {
                Id = x.Id,
                Username = x.Username,
                Active = x.Active,
                Email = x.Email
            }).ToListAsync();

            return rec;
        }

        public async Task<UserAccount> GetUserById(int id)
        {
            var rec = await _dbcontext.UserAccount.Where(x =>  x.Id == id).Select(x => new UserAccount()
            {
                Id = x.Id,
                Username = x.Username,
                Active = x.Active,
                Email = x.Email
            }).FirstOrDefaultAsync();

            return rec;
        }
    }
}
