using IRIS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRIS.Data
{
    public interface IUserRoleRepository : IRepository<UserRole>
    {
        List<UserRole> GetUserRoles();
        List<UserRole> GetUserRolesByUserId(long UserId);
    }
}
