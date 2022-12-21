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
                    Console.WriteLine("Menu");
                    Console.WriteLine("1. Insert Data");
                    Console.WriteLine("2. Delete Data");
                    Console.WriteLine("3. Display Data");
                    Console.WriteLine("4. Exit");
                    Console.Write("\nEnter your choice: ");
                    ch = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine();
                }
                catch
                {
                    Console.WriteLine("Silahkan periksa kembali data yang kamu masukan!");
                }
            }
        }
    }
}
