﻿using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Transactions;

namespace DataStructures.LinkedList
{
    public class LinkedLister
    {
        public Node Head { get; set; }


        public void Insert(int value)
        {
            Node newNode = new Node(value);

            newNode.Next = Head;

            Head = newNode;
        }

        public bool Includes(int value)
        {
            Node current = Head;
            int input = value;

            while (current != null)
            {
                if (current.Value == input)
                {
                    return true;

                }
                current = current.Next;

            }
            return false;

        }

        public override string ToString()
        {
            Node current = Head;
            string result = "";

            while (current != null)
            {
                result += $"{{ {current.Value} }} ->";
                current = current.Next;

            }
            return result + "NULL";

        }
        public void Append(int value)
        {
            Node node = new Node(value);
            Node current = Head;

            while (current.Next != null)
            {
                current = current.Next;

            }

            current.Next =  node;
        }

        public int SearchListForKthValueFromEnd(int value)
        {
            Node current = Head;
            int count = 0;

            while (current != null)
            {
                count++;

                current = current.Next;
            }
            if(value > count)
            {
                throw new NullReferenceException();
            }

            current = Head;
            for(int i = 0; i < count - value; i++)
            {
                current.current.Next;
            }
            return current.Value;
        }
       
    }

}


    

        
        
    
