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

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
