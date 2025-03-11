using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tecoc.Get.Apis.Models;
using Tecoc.Get.Apis.Repositories.interfaces;

namespace Tecoc.Get.Apis.Repositories
{
    public class UserRepository : IUserRepository
    {
        public Task<List<UserModel>> GetUsers()
        {
            throw new NotImplementedException();
        }
    }
}