﻿using System;
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
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
