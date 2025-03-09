using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tecoc.Get.Apis.Models;

namespace tecoc.Get.Apis.Repositories.interfaces
{
    public interface IUserRepository
    {
        Task<List<UserModel>> GetUsers();
    }
}