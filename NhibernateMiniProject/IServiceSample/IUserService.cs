using System.Collections.Generic;
using Models;

namespace IServiceSample
{
    public interface IUserService
    {
        void UserAdded(User userModel);
        IList<User> UserList();
    }
}
