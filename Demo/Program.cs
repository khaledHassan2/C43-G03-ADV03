﻿namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LinkedList
            //LinkedList<int> Numbers = new LinkedList<int>();
            //Numbers.AddFirst(1);
            //Numbers.AddAfter(Numbers.First, 2);
            //Numbers.AddLast(2);
            //LinkedListNode<int> sec = Numbers.Find(2);
            //Numbers.AddBefore(sec, 22);

            //foreach (int item in Numbers)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region Stack
            ////first inp last out
            //Stack<int>Num = new Stack<int>();
            //Num.Push(1);
            //Num.Push(2);
            //Num.Push(3);

            //Console.WriteLine(Num.Pop()); //3
            //Console.WriteLine(Num.Pop()); //2
            //Console.WriteLine(Num.Pop()); //1

            //Console.WriteLine(Num.TryPop(out int lnum));

            //foreach (var item in Num)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Queue
            //// first in first out 
            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            ////  queue.Dequeue();// 1
            //Console.WriteLine(queue.Dequeue());//1
            //Console.WriteLine(queue.Dequeue());//2
            //Console.WriteLine(queue.Dequeue());//3

            //// Console.WriteLine(queue.Dequeue());// EX
            //Console.WriteLine(queue.TryDequeue(out int lnum));

            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region HashTable non-gnaric
            //// key and Value
            //Hashtable Note = new Hashtable();

            //Note.Add("khaled", 01140069427);
            //Note.Add("mo", 01140069427);
            //Note.Add("wagdy", 01140069427);

            //// Note.Add("wagdy", 01140069427);// EX key must be unique
            ////protective code
            //if (!Note.ContainsKey("khaled"))
            //{
            //    Note.Add("khaled",01140069427);
            //}
            //else{
            //    Console.WriteLine("InValid");
            //}

            //foreach (DictionaryEntry  item in Note)
            //{
            //    Console.WriteLine($"{item.Key}  //  {item.Value}");
            //}
            #endregion
        }
    }
}
