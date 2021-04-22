using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOOP
{
    class Employees
    {
        public string Name { get; set; }
        public string Nip { get; set; }
        public int Dob { get; set; }
        public int Salary { get; set; }

        public Employees(string name, string nip, int dob, int salary)
        {
            Name = name;
            Nip = nip;
            Dob = dob;
            Salary = salary;
        }

        public string GetStatus()
        {
            if (DateTime.Now.Year - Dob > 60)
            {
                return "Diizinkan Untuk Pensiun";
            }
            else
            {
                return "Belum Diizinkan Untuk Pensiun";
            }
        }

        public int GetAge()
        {
            return DateTime.Now.Year - Dob;
        }
    }
}
