﻿using IRIS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRIS.Data
{
    public interface IUserRepository : IRepository<User>
    {
        User GetByUserName(string userName);
        User GetByFirstName(string firstName);
        //List<User> GetAllActiveUsersByNameRoleId(string Name, long RoleId);
        //User FindUser(string userName, string passWord);
    }
}
