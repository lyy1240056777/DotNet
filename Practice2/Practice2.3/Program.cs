using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2._3
{
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }
        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }
    public class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public GenericList()
        {
            tail = head = null;
        }

        public Node<T> Head
        {
            get => head;
        }

        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if (tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }

        public void ForEach(Action<T> action)
        {
            for(Node<T> it=head;it!=null;it=it.Next)
            {
                action(it.Data);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> genericList = new GenericList<int>();
            for(int i=1;i<=10;i++)
            {
                genericList.Add(i);
            }
            int max = genericList.Head.Data;
            int min = genericList.Head.Data;
            int sum = 0;
            Console.WriteLine("链表元素有:");
            genericList.ForEach(s =>
            {
                Console.Write(s+" ");
                max = Math.Max(max, s);
                min = Math.Min(min, s);
                sum += s;
            });
            Console.WriteLine($"\nmax:{max} min={min} sum={sum}");
        }
    }
}
