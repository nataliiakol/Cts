using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Users
{
    public class Manager : SystemUser {

        private static Manager vInstance;

        protected Manager() {
            
        }

        public static Manager Instance() {
            if (vInstance == null) {
                vInstance = new Manager();
            }
            return vInstance;
        }
    }
}
