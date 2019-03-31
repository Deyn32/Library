using System.Runtime.Remoting.Messaging;
using System.Web;
using NHibernate;
using NHibernate.Cfg;
using System.Xml;
using System.Diagnostics;
using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Library
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
                HttpContext context = HttpContext.Current;
                currentSession = context.Items[sessionKeySQLServer] as ISession;

                if (currentSession == null && getNewIfNotExists)
                {
                    currentSession = sessionFactorySQLServer.OpenSession();
                    context.Items[sessionKeySQLServer] = currentSession;
                }
            }
            else
            {
                currentSession = CallContext.GetData(sessionKeySQLServer) as ISession;

                if (currentSession == null && getNewIfNotExists)
                {
                    currentSession = sessionFactorySQLServer.OpenSession();
                    CallContext.SetData(sessionKeySQLServer, currentSession);
                }
                else if (currentSession != null && getNewIfNotExists)
                {
                    currentSession = sessionFactorySQLServer.OpenSession();
                    CallContext.SetData(sessionKeySQLServer, currentSession);
                }
            }

            return currentSession;
        }

        public void Init()
        {
            Assembly asemb = Assembly.GetExecutingAssembly();
            String fileConf = @"Library.Config.NHiberConfig.cfg.xml";
            try
            {
                sessionFactorySQLServer = new Configuration().Configure(asemb, fileConf).BuildSessionFactory();
            }
            catch(Exception ex)
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
