using Models;
using FluentNHibernate.Mapping;

namespace NhibernateMapping
{
    public class UserMapping:ClassMap<User>
    {
        public UserMapping()
        {
            Table("UserTable");
            Id(u => u.TableId).GeneratedBy.Identity();
            Map(u=>u.FirstName).Not.Nullable();
            Map(u => u.LastName).Not.Nullable();
            Map(u => u.Age).Not.Nullable();
            Map(u => u.RegisteredDate).Not.Nullable();
        }
    }
}
