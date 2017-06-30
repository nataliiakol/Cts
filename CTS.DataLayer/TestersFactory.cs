using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1.Users;

namespace CTS.DataLayer
{
    public class TestersFactory : SystemUserFactory
    {
        public override SystemUser GetSystemUser() {
            return new Tester();
        }
    }
}
