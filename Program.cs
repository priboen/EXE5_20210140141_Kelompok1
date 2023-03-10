using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXE5_20210140141_Kelompok1
{
    class Node
    {
        public string nama;
        public Node next;
    }
    class queue
    {
        Node adri, khamid;
        public queue()
        {
            adri = null;
            khamid = null;
        }
        public void insert()
        {
            string valueread;
            Node newnode = new Node();
            Console.Write("Masukan Input : ");
            valueread = Console.ReadLine();
            newnode.nama = valueread;
            newnode.next = null;
            if (adri == null)
            {
                adri = newnode;
                khamid = newnode;
                return;
            }
            khamid.next = newnode;
            khamid = newnode;
        }
        public void delete()
        {
            if (adri == null)
            {
                Console.WriteLine("Tidak ada data dalam antrian!");
                return;
            }
            Console.WriteLine("Data yang dihapus dari antrian : " + adri.nama);
            Console.ReadKey();
            adri = adri.next;
            if (adri == null)
                khamid = null;
        }
        public void display()
        {
            if (adri == null)
            {
                Console.WriteLine("Tidak ada data dalam antrian!");
                return;
            }
            Node display;
            for (display = adri; display != null; display = display.next)
                Console.WriteLine(display.nama);
            Console.WriteLine("\nTekan 'Enter' untuk melanjutkan Program");
            Console.ReadKey();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            queue qw = new queue();
            char ch;
            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Menu");
                    Console.WriteLine("1. Insert Data");
                    Console.WriteLine("2. Delete Data");
                    Console.WriteLine("3. Display Data");
                    Console.WriteLine("4. Exit");
                    Console.Write("\nEnter your choice: ");
                    ch = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine();
                    switch (ch)
                    {
                        case '1':
                            Console.Clear();
                            qw.insert();
                            break;
                        case '2':
                            Console.Clear();
                            qw.delete();
                            break;
                        case '3':
                            Console.Clear();
                            qw.display();
                            break;
                        case '4':
                            return;
                        default:
                            Console.WriteLine("Invalid Option");
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Silahkan periksa kembali data yang kamu masukan!");
                }
            }
        }
    }
}
