using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pegawai> instances = new List<Pegawai>();
            Menu(instances);
        }

        static void Menu(List<Pegawai> instances)
        {
            TampilMenu();
            int opsi = Convert.ToInt32(Console.ReadLine());
            switch (opsi)
            {
                case 1:
                    TambahInstansi(instances);
                    break;
                case 2:
                    TambahPegawai(instances);
                    break;
                case 3:
                    HapusDataPegawai(instances);
                    break;
                case 4:
                    HapusDataInstansi(instances);
                    break;
                case 5:
                    TampilDataInstansi(instances);
                    break;
                case 6:
                    TampilDataInstansiPegawai(instances);
                    break;
                case 0:
                    Console.WriteLine("Terima Kasih!");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Pilihan Tidak Ditemukan, Silahkan Mengulang!");
                    Console.ReadLine();
                    MenuRepeat(instances);
                    break;
            }
        }

        private static void TampilMenu()
        {
            Console.WriteLine("=====Menu=====");
            Console.WriteLine("1. Tambah Instansi");
            Console.WriteLine("2. Tambah Pegawai");
            Console.WriteLine("3. Hapus Data Pegawai");
            Console.WriteLine("4. Hapus Data Instansi");
            Console.WriteLine("5. Tampilkan Daftar Instansi");
            Console.WriteLine("6. Tampilkan Daftar Instansi dan Pegawai");
            Console.WriteLine("0. Keluar");
        }

        private static void TampilDataInstansiPegawai(List<Pegawai> instances)
        {
            Console.Clear();
            for (int i = 0; i < instances.Count; i++)
            {
                Console.WriteLine($"NO.{i + 1}");
                Console.WriteLine($"Nama Instansi : {instances[i].Instance}");
                Console.WriteLine($"ID Instansi : {instances[i].Id}");
                Console.WriteLine("=====Daftar Pegawai=====");
                instances[i].ShowAllEmployees();
                Console.WriteLine("");
            }
            MenuRepeat(instances);
        }

        private static void TampilDataInstansi(List<Pegawai> instances)
        {
            Console.Clear();
            Console.WriteLine("=====List Instansi=====");
            ShowInstances(instances);
            Console.ReadLine();
            MenuRepeat(instances);
        }

        private static void HapusDataInstansi(List<Pegawai> instances)
        {
            Console.Clear();
            Console.WriteLine("=====List Instansi=====");
            ShowInstances(instances);
            if (instances.Count > 0)
            {
                Console.WriteLine("Pilih Instansi");
                int opsiDelInstance = Convert.ToInt32(Console.ReadLine());
                string insName = instances[opsiDelInstance - 1].Instance;
                Console.WriteLine($"Apakah Anda Yakin Akan Menghapus Instansi {instances[opsiDelInstance - 1].Instance}? (Y/N)");
                string konfirmasi = Console.ReadLine();
                if (konfirmasi == "Y")
                {
                    instances.RemoveAt(opsiDelInstance - 1);

                    Console.Clear();
                    Console.WriteLine($"Data Instansi {insName} Berhasil Dihapus!!!");
                    MenuRepeat(instances);
                }
                else
                {
                    MenuRepeat(instances);
                }
            }
            else
            {
                MenuRepeat(instances);
            }
        }

        private static void HapusDataPegawai(List<Pegawai> instances)
        {
            Console.Clear();
            Console.WriteLine("=====List Instansi=====");
            ShowInstances(instances);

            Console.WriteLine("Pilih Instansi");
            int opsiInstanceDel = Convert.ToInt32(Console.ReadLine());
            Pegawai instansiDel = instances.ElementAt(opsiInstanceDel - 1);

            Console.Clear();
            Console.WriteLine("=====Instansi Terpilih=====");
            Console.WriteLine($"Nama Instansi : {instansiDel.Instance}");
            Console.WriteLine($"ID Instansi   : {instansiDel.Id}");
            Console.WriteLine("===========================");
            instansiDel.ShowAllEmployees();

            Console.WriteLine("Pilih Pegawai Yang Ingin Dihapus");
            int delOption = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Apakah Anda Yakin Akan Menghapus Pegawai {instansiDel.Employees[delOption - 1].Name}? (Y/N)");
            string konfirmasi = Console.ReadLine();
            if (konfirmasi == "Y")
            {
                instansiDel.Employees.RemoveAt(delOption - 1);

                Console.Clear();

                Console.WriteLine("Data Pegawai Berhasil Dihapus!!!");
                MenuRepeat(instances);
            }
            else
            {
                MenuRepeat(instances);
            }
        }

        private static void TambahPegawai(List<Pegawai> instances)
        {
            Console.Clear();
            Console.WriteLine("=====List Instansi=====");
            ShowInstances(instances);

            if (instances.Count > 0)
            {
                Console.WriteLine("Pilih Instansi");
                int opsiInstance = Convert.ToInt32(Console.ReadLine());
                if (opsiInstance - 1 > (instances.Count - 1) || opsiInstance - 1 < 0)
                {
                    Console.Clear();
                    Console.WriteLine("Pilihan Diluar Index");
                    Console.ReadLine();
                    Console.Clear();
                    MenuRepeat(instances);
                }
                else
                {
                    Pegawai instansi = instances.ElementAt(opsiInstance - 1);

                    Console.Clear();
                    Console.WriteLine("=====Instansi Terpilih=====");
                    Console.WriteLine($"Nama Instansi : {instansi.Instance}");
                    Console.WriteLine($"ID Instansi   : {instansi.Id}");
                    Console.WriteLine("===========================");
                    Console.WriteLine("Formulir Input Data Pegawai");
                    Console.WriteLine("");
                    Console.WriteLine("Nama        : ");
                    string employeesName = Console.ReadLine();
                    Console.WriteLine("NIP         : ");
                    string employeesNip = Console.ReadLine();
                    Console.WriteLine("Tahun Lahir :");
                    int employeesDob = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Gaji        :");
                    int employeesSalary = Convert.ToInt32(Console.ReadLine());
                    Employees employees = new Employees(employeesName, employeesNip, employeesDob, employeesSalary);

                    instansi.Employees.Add(employees);
                    Console.Clear();
                    Console.WriteLine($"Berhasil Menambahkan {employeesName} Sebagai Pegawai Pada Instansi {instansi.Instance} !!!");
                    MenuRepeat(instances);
                }
            }
            else
            {
                Console.WriteLine("");
                MenuRepeat(instances);
            }
        }

        private static void TambahInstansi(List<Pegawai> instances)
        {
            Console.Clear();
            Console.WriteLine("=====Form Input Instansi=====");
            Console.WriteLine("Masukkan ID Instansi   : ");
            string instanceId = Console.ReadLine();
            Console.WriteLine("Masukkan Nama Instansi : ");
            string instanceName = Console.ReadLine();
            instances.Add(new Pegawai(($"{instanceName.Substring(0, 1)}{instanceName.Substring(4, 1)}-{instanceId}"), instanceName));
            Console.WriteLine("Berhasil Menambahkan Instansi Baru");
            //Console.ReadLine();
            MenuRepeat(instances);
        }

        static void MenuRepeat(List<Pegawai> instances)
        {
            Console.WriteLine("Ingin Melanjutkan? (Y/N)");
            string opsi = Console.ReadLine();
            switch (opsi)
            {
                case "Y":
                    Console.Clear();
                    Menu(instances);
                    break;
                case "N":
                    Console.Clear();
                    Console.WriteLine("TERIMA KASIH!!");
                    Console.ReadLine();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Opsi Salah, Pilih (Y/N)");
                    MenuRepeat(instances);
                    break;
            }
        }

        static void ShowInstances(List<Pegawai> instances)
        {
            if (instances.Count==0)
            {
                Console.WriteLine("List Instansi Kosong");
                Console.WriteLine("");
            }
            else
            {
                for (int i = 0; i < instances.Count; i++)
                {
                    Console.WriteLine($"NO.{i + 1}");
                    Console.WriteLine($"Nama Instansi : {instances[i].Instance}");
                    Console.WriteLine($"ID Instansi : {instances[i].Id}");
                    Console.WriteLine("");
                }
            }
            
        }
    }
}
