using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Connection
    {
        private static Connection connection;
        private static Object _lock = new Object();

        private string server;

        private Connection() {
            this.server = "SERVER//ACDC";
        }

        public static Connection GetInstance() {
            lock (_lock) {
                return connection ?? (connection = new Connection());
            }
        }

        public String Status() {
            return "OK";
        }
    }
}
