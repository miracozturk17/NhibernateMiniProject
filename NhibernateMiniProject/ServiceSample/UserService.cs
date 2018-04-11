using System.Collections.Generic;
using IServiceSample;
using Models;
using RepositorySample;

namespace ServiceSample
{
    public class UserService : IUserService
    {
        private readonly RepositroyBase<User> _repository = new RepositroyBase<User>();


        public void UserAdded(User userModel)
        {
            _repository.Insert(userModel);
        }

        public IList<User> UserList()
        {
            return _repository.GetList();
        }
    }
}
