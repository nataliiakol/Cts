using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTS.BusinessLayer.Users;

namespace CTS.DataLayer
{
    public class TestersFactory : SystemUserFactory
    {
        public override SystemUser GetSystemUser() {
            return new Tester();
        }
    }
}
