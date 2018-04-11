using FluentNHibernate.Mapping;
using Models;

namespace NhibernateMapping
{
    public class UserExperienceMapping:ClassMap<UserExperience>
    {
        public UserExperienceMapping()
        {
            Table("UserExperienceTable");
            Id(u => u.TableId).GeneratedBy.Identity();
            Map(u => u.Description);
            Map(u => u.CountExperience).Not.Nullable();
            Map(u => u.UserId);
            Map(u => u.RegistredDate);
        }
    }
}
