using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NhibernateMapping;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

namespace NhibernateDb
{
    public class NhibernateSqlContext
    {
        private static ISessionFactory session;

        private static ISessionFactory CreateSession()
        {
            if (session != null) return session;

            FluentConfiguration _config = Fluently.Configure().Database(MsSqlConfiguration.MsSql2012.ConnectionString(
                    x => x
                        .Server("DESKTOP-AGSP67K")
                        .Username(@"DESKTOP-AGSP67K\Casper")
                        .Password("")
                        .Database("NhibernateDB")
                ))
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<UserExperienceMapping>())
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<UserMapping>())
                .ExposeConfiguration(cfg => new SchemaUpdate(cfg).Execute(false, true));
            session = _config.BuildSessionFactory();
            return session;
        }

        public static ISession SessionOpen()
        {
            return CreateSession().OpenSession();
        }
    }
}
