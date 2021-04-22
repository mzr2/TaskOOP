using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOOP
{
    class Pegawai
    {
        public string Id { get; set; }
        public string Instance { get; set; }
        public List<Employees> Employees { get; set; }
        

        public Pegawai(string id, string instance)
        {
            Id = id;
            Instance = instance;
            Employees = new List<Employees>();
        }

        public void ShowAllEmployees()
        {
            if (Employees.Count==0)
            {
                Console.WriteLine("Data Pegawai Kosong");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine($"Data Pegawai {Instance}");
                for (int i = 0; i < Employees.Count; i++)
                {
                    Console.WriteLine($"NO.{i + 1}");
                    Console.WriteLine($"Nama          : {Employees[i].Name}");
                    Console.WriteLine($"NIP           : {Employees[i].Nip}");
                    Console.WriteLine($"Tanggal Lahir : {Employees[i].Dob}");
                    Console.WriteLine($"Umur          : {Employees[i].GetAge()}");
                    Console.WriteLine($"Gaji          : {Employees[i].Salary}");
                    Console.WriteLine($"Status        : {Employees[i].GetStatus()}");
                    Console.WriteLine("");
                }
            }
            
        }
        
    }
}
