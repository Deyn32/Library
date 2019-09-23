using System.Runtime.Remoting.Messaging;

using System;
using NHibernate;
using System.Web;
using System.Reflection;
using NHibernate.Cfg;
using System.Windows.Forms;

namespace Domain
{
    public class Domain
    {
        private const String sessionKeySQLServer = "private const string sessionKeySQLServer";
        private static ISessionFactory sessionFactorySQLServer;

        public ISession currentSession
        {
            get
            {
                return GetSession(true);
            }
        }

        private ISession GetSession(bool getNewIfNotExists)
        {
            ISession currentSession;

            if (HttpContext.Current != null)
            {
                currentSession = GetCurrentHttpContext(getNewIfNotExists);
            }
            else
            {
                currentSession = GetCallContext(getNewIfNotExists);
            }

            return currentSession;
        }

        private ISession GetCurrentHttpContext(bool getNewIfNotExists)
        {
            ISession currentSession;
            HttpContext context = HttpContext.Current;
            currentSession = context.Items[sessionKeySQLServer] as ISession;

            if (currentSession == null && getNewIfNotExists)
            {
                currentSession = sessionFactorySQLServer.OpenSession();
                context.Items[sessionKeySQLServer] = currentSession;
            }

            return currentSession;
        }

        private ISession GetCallContext(bool getNewIfNotExists)
        {
            ISession session;
            session = CallContext.GetData(sessionKeySQLServer) as ISession;

            if (session == null && getNewIfNotExists)
            {
                session = sessionFactorySQLServer.OpenSession();
                CallContext.SetData(sessionKeySQLServer, session);
            }
            else if (session != null && getNewIfNotExists)
            {
                session = sessionFactorySQLServer.OpenSession();
                CallContext.SetData(sessionKeySQLServer, session);
            }
            return session;
        }

        public void Init()
        {
            Assembly asemb = Assembly.GetExecutingAssembly();
            String fileConf = @"Domain.Config.NHiberConfig.cfg.xml";
            try
            {
                sessionFactorySQLServer = new Configuration().Configure(asemb, fileConf).BuildSessionFactory();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Нет подключения у БД\n" + ex.ToString());
            }
        }

        public void Close()
        {
            ISession currentSession = GetSession(false);

            if (currentSession != null)
            {
                if (currentSession.IsOpen) currentSession.Close();
            }
        }
    }
}
