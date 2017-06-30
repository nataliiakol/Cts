using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1.Users;

namespace CTS.DataLayer
{
    public abstract class SystemUserFactory {
        public abstract SystemUser GetSystemUser();
    }
}
