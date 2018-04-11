using System;
using System.Collections.Generic;

namespace Models
{
    public class User
    {
        public virtual int TableId { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual int Age { get; set; }
        public virtual DateTime RegisteredDate { get; set; }

        public IList<UserExperience> Experience { get; set; }

        public User()
        {
            Experience=new List<UserExperience>();
        }
    }
}
