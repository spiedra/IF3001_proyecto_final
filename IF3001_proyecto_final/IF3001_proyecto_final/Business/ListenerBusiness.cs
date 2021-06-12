using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using IF3001_proyecto_final.Cluster;

namespace IF3001_proyecto_final.Business
{
    class ListenerBusiness
    {
        List<object> listDataClasses;
        private ListenerCluster listenerCluster;

        public ListenerBusiness()
        {
            this.listenerCluster = new ListenerCluster();
            this.InitListDataClasses();
        }

        public object ConnectToListener(string className, string actionName, object[] parameters)
        {
            if (this.listenerCluster.IsMainNodeReady())
            {
                return this.ExcecuteNode(className, actionName, parameters, "SqlServerBusiness");
            }
            else
            {
                return this.ExcecuteNode(className, actionName, parameters, "MySqlBusiness");
            }
        }

        private object ExcecuteNode(string className, string actionName, object[] parameters, string identifier)
        {
            foreach (object dataClass in this.listDataClasses)
            {
                if (dataClass.ToString().Equals(className + identifier))
                {
                    MethodInfo mi = dataClass.GetType().GetMethod(actionName);
                    return mi.Invoke(dataClass, parameters);
                }
            }
            return null;
        }

        private void InitListDataClasses()
        {
            this.listDataClasses = new List<object>();
            this.listDataClasses.Add(new EstudianteSqlServerBusiness());
            this.listDataClasses.Add(new EstudianteMySqlBusiness());
        }
    }
}
