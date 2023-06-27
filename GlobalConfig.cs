using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamifyClassLibrary
{
    public static class GlobalConfig
    {
        public static List<SQLConnection> Connections { get; private set; } = new List<SQLConnection>();

        public static void InitializeConnection()
        {
            //create a sql connection
            SQLConnection conn = new SQLConnection();
            Connections.Add(conn);

        }
    }
}
