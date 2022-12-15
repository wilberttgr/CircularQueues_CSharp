﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularQueues_CSharp
{
    class Queues
    {
        int FRONT, REAR, max = 5;
        int[] queue_array = new int[5];
        public Queues()
        {
            FRONT = -1;
            REAR = -1;
        }
        public void insert(int element)
        {
            if ((FRONT == 0 && REAR == max - 1) || (FRONT == REAR + 1))
            {
                Console.WriteLine("\nQueue overvlow\n");
                return;
            }
            if (FRONT == -1)
            {
                FRONT = 0;
                REAR = 0;
            }
            else
            {
                if (REAR == max - 1)
                    REAR = 0;
                else
                    REAR = REAR + 1;
            }
            queue_array[REAR] = element;
        }
        public void remove()
        {
            if (FRONT == -1)
            {
                Console.WriteLine("Queue underflow\n");
                return;
            }
            Console.WriteLine("\nThe element deleted from the queue is: " + queue_array[FRONT] + "\n");
            if (FRONT == REAR)
            {
                FRONT = -1;
                REAR = -1;
            }
            else
            {
                if (FRONT == max - 1)
                    FRONT = 0;
                else
                    FRONT = FRONT + 1;
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
