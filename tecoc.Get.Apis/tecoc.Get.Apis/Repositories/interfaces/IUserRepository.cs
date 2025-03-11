using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tecoc.Get.Apis.Models;

namespace Tecoc.Get.Apis.Repositories.interfaces
{
    public interface IUserRepository
    {
        Task<List<UserModel>> GetUsers();
    }
}