using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTS.BusinessLayer.Users
{
    interface ISystemUser
    {
        string UserId { get; set; }
        string Name { get; set; }
        int Salary { get; set; }
        void ReceiveSalary();
    }
}
