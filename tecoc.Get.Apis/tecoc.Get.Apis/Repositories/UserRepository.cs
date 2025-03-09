using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tecoc.Get.Apis.Models;
using tecoc.Get.Apis.Repositories.interfaces;

namespace tecoc.Get.Apis.Repositories
{
    public class UserRepository : IUserRepository
    {
        public Task<List<UserModel>> GetUsers()
        {
            throw new NotImplementedException();
        }
    }
}