using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SampleCoreAPI.Data.ViewModels;
using SampleCoreAPI.Models;

namespace SampleCoreAPI.Data.Services
{
    public interface IUserService
    {
        Task<List<UserAccount>> GetUsers();
        Task<UserAccount> GetUserById(int id);
        Task<int> AddUser(UserVM user);
        Task UpdateUser(int id, UserVM user);
    }
}
