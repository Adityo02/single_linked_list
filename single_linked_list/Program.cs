﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace single_linked_list
{
    //each node consist of the information partand link to the next node
    class Node
    {
        public int rollNumber;
        public string name;
        public Node next;
    }

    class List
    {
        Node START;
        public List()
        {
            START = null;
        }
        public void addNote() //add a node in the list
        {
            int rollNo;
            string nm;
            Console.Write("\nEnter the roll Number of the student : ");
            rollNo = Convert.ToInt32(Console.ReadLine);
            Console.Write("\nEnter the roll Name of the student : ");
            nm = Console.ReadLine();
            Node newnode = new Node();
            newnode.rollNumber = rollNo;
            newnode.name = nm;
            
            //if the node to be inserted is the first node
            if(START == null || rollNo <= START.rollNumber)
            {
                if((START != null) && (rollNo == START.rollNumber))
                {
                    Console.WriteLine();
                    return;
                }
                newnode.next = START;
                START = newnode;
                return;
            }

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
