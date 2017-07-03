using System;
using System.Collections.Generic;
using CTS.BusinessLayer.Users;

namespace CTS.BusinessLayer
{
    public delegate void SalaryTime();

    public class CompanyStorage {
        public event SalaryTime OnSalaryGiven;
        public List<Tester> Testers;
        public List<Developer> Developers;

        public void GiveSalary() {
            if (OnSalaryGiven != null) OnSalaryGiven();
        }
    }


}
