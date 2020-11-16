﻿using API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Interfaceses
{
    public interface IUserReposytiry
    {
        Task<IEnumerable<User>> GetUsersAsync();
        Task<User> GetUserAsync(long id);
    }
}
