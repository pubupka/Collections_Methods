using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using System.Threading;

namespace Collections
{
    public class Collections_Methods
    {
        public class Array_Methods : Collections_Methods
        {
            static int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            public static void Sort()
            {
                Array.Sort(arr);
            }

            public static void Reverse()
            {
                Array.Reverse(arr);
            }

            public static void BinarySearch()
            {
                Console.Clear();
                Console.SetCursorPosition(0, 0);
                int[] copy = new int[arr.Length];
                arr.CopyTo(copy, 0);
                Array.Sort(copy);

                bool flag = true;

                for (int i = 0; i < copy.Length; i++)
                {
                    if (copy[i] != arr[i])
                    {
                        flag = false;
                        break;
                    }
                }

                if (flag)
                {
                    Console.WriteLine("Какое число найти?");
                    int number = int.Parse(Console.ReadLine());
                    int index = Array.BinarySearch(arr, number);
                    Console.WriteLine("Искомый индекс = " + index);
                }
                else
                    Console.WriteLine("Массив не отсортирован");

                Console.WriteLine("Нажмите любую клавишу");
                Console.ReadKey();
                Console.Clear();

            }

            public static void Clear()
            {
                Array.Clear(arr);
            }

            public static void SetValue()
            {
                Console.Clear();

                Console.WriteLine("По какому индексу изменить значение?");
                int index = int.Parse(Console.ReadLine());
                Console.WriteLine("Какое значение присвоить?");
                int value = int.Parse(Console.ReadLine());

                arr.SetValue(value, index);

                Console.Clear();
            }

            public static void IndexOf()
            {
                Console.Clear();

                Console.WriteLine("Индекс какого элемента показать?");
                int value = int.Parse(Console.ReadLine());
                Console.WriteLine("Индекс первого вхождения: {0}", Array.IndexOf(arr, value));

                Console.WriteLine("Нажмите любую клавишу");
                Console.ReadKey();

                Console.Clear();
            }

            public static void LastIndexOf()
            {
                Console.Clear();

                Console.WriteLine("Индекс какого элемента показать?");
                int value = int.Parse(Console.ReadLine());
                Console.WriteLine("Индекс последнего вхождения: {0}", Array.LastIndexOf(arr, value));

                Console.WriteLine("Нажмите любую клавишу");
                Console.ReadKey();

                Console.Clear();
            }

            public static void GetValue()
            {
                Console.Clear();

                Console.WriteLine("По какому индексу получить значение?");
                int index = int.Parse(Console.ReadLine());
                Console.WriteLine("Значение по данному индексу: {0}", arr.GetValue(index));

                Console.WriteLine("Нажмите любую клавишу");
                Console.ReadKey();

                Console.Clear();
            }

            public static void Length()
            {
                Console.Clear();
                Console.WriteLine("Длина массива: {0} элементов", arr.Length);

                Console.WriteLine("Нажмите любую клавишу");
                Console.ReadKey();

                Console.Clear();
            }

            public static void Write()
            {
                Console.WriteLine("Массив: [{0}", String.Join(", ", arr) + "]");
            }
        }

        public class ArrayList_Methods : Collections_Methods
        {
            static ArrayList arrlist = new ArrayList() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            public static void Sort()
            {
                arrlist.Sort();
            }

            public static void Reverse()
            {
                arrlist.Reverse();
            }

            public static void BinarySearch()
            {
                Console.Clear();
                Console.SetCursorPosition(0, 0);
                int[] copy = new int[arrlist.Count];
                arrlist.CopyTo(copy, 0);
                Array.Sort(copy);

                bool flag = true;

                for (int i = 0; i < copy.Length; i++)
                {
                    if (copy[i] != int.Parse(Convert.ToString(arrlist[i])))
                    {
                        flag = false;
                        break;
                    }
                }

                if (flag)
                {
                    Console.WriteLine("Какое число найти?");
                    int number = int.Parse(Console.ReadLine());
                    int index = arrlist.BinarySearch(number);
                    Console.WriteLine("Искомый индекс = " + index);
                }
                else
                    Console.WriteLine("Массив не отсортирован");

                Console.WriteLine("Нажмите любую клавишу");
                Console.ReadKey();
                Console.Clear();

            }

            public static void Clear()
            {
                arrlist.Clear();

            }

            public static void Add()
            {
                Console.Clear();
                while (true)
                {
                    Console.WriteLine("Введите элемент для добавления");
                    int element = int.Parse(Console.ReadLine());
                    arrlist.Add(element);
                    Console.WriteLine("Добавить ещё?");
                    string answer = Console.ReadLine();
                    if (answer == "да" || answer == "Да" || answer == "yes" || answer == "Yes")
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }

                Console.WriteLine("Нажмите любую клавишу");
                Console.ReadKey();

                Console.Clear();
            }

            public static void IndexOf()
            {
                Console.Clear();
                Console.WriteLine("Индекс первого вхождения какого элемента вывести?");
                int element = int.Parse(Console.ReadLine());
                Console.WriteLine("Индекс первого вхождения: {0}", arrlist.IndexOf(element));

                Console.WriteLine("Нажмите любую клавишу");
                Console.ReadKey();

                Console.Clear();
            }

            public static void LastIndexOf()
            {
                Console.Clear();
                Console.WriteLine("Индекс последнего вхождения какого элемента вывести?");
                int element = int.Parse(Console.ReadLine());
                Console.WriteLine("Индекс последнего вхождения: {0}", arrlist.LastIndexOf(element));

                Console.WriteLine("Нажмите любую клавишу");
                Console.ReadKey();

                Console.Clear();
            }

            public static void Remove()
            { Console.Clear();
                Console.WriteLine("Первое вхождение какого элемента удалить?");
                int element = int.Parse(Console.ReadLine());
                arrlist.Remove(element);

                Console.WriteLine("Нажмите любую клавишу");
                Console.ReadKey();

                Console.Clear();
            }

            public static void Length()
            {
                Console.Clear();
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Длина массива: {0} элементов", arrlist.Count);

                Console.WriteLine("Нажмите любую клавишу");
                Console.ReadKey();

                Console.Clear();

            }
            public static void Write()
            {
                Console.Write("ArrayList: [");
                for (int i = 0; i < arrlist.Count; i++)
                {
                    if (i == arrlist.Count - 1)
                    {
                        Console.Write(arrlist[i]);
                        break;
                    }
                    Console.Write(arrlist[i] + ", ");
                }
                Console.WriteLine("]");
            }
        }

        public class HashTable_Methods : Collections_Methods
        {
            static Hashtable hashtable = new Hashtable();

            public static void ContainsValue()
            {
                Console.Clear();

                if (hashtable.ContainsKey(1))
                    Console.WriteLine("В таблице есть значение чатыре");
                else
                    Console.WriteLine("В таблице нет значения чатыре");

                Console.WriteLine("Нажмите любую клавишу");
                Console.ReadKey();
                Console.Clear();
            }

            public static void ContainsKey()
            {
                Console.Clear();

                if (hashtable.ContainsKey(1))
                    Console.WriteLine("В таблице есть ключ 1");
                else
                    Console.WriteLine("В таблице нет ключа 1");

                Console.WriteLine("Нажмите любую клавишу");
                Console.ReadKey();
                Console.Clear();
            }

            public static void Values()
            {
                Console.Clear();

                Console.Write("Значения: ");
                foreach (string value in hashtable.Values)
                {
                    Console.Write(value + " ");
                }

                Console.WriteLine("Нажмите любую клавишу");
                Console.ReadKey();
                Console.Clear();
            }

            public static void Keys()
            {
                Console.Clear();

                Console.Write("Ключи: ");
                foreach (int key in hashtable.Keys)
                {
                    Console.Write(key + " ");
                }

                Console.WriteLine("Нажмите любую клавишу");
                Console.ReadKey();
                Console.Clear();
            }

            public static void Count()
            {
                Console.Clear();
                Console.WriteLine("В таблице {0} пар ключ-значение", hashtable.Count);
                Console.WriteLine("Нажмите любую клавишу");
                Console.ReadKey();
                Console.Clear();
            }

            public static void Remove()
            {
                Console.Clear();
                Console.WriteLine("Введите ключ в целочисленном формате");
                int key = int.Parse(Console.ReadLine());
                hashtable.Remove(key);
                Console.Clear();
            }

            public static void Add()
            {
                Console.Clear();
                while (true)
                {
                    Console.WriteLine("Введите ключ в целочисленном формате");
                    string key = Console.ReadLine();
                    Console.WriteLine("Введите значение");
                    string value = Console.ReadLine();
                    hashtable.Add(key, value);

                    string answer = Console.ReadLine();
                    if (answer == "да" || answer == "Да" || answer == "yes" || answer == "Yes")
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                Console.WriteLine("Нажмите любую клавишу");
                Console.ReadKey();

                Console.Clear();
            }

            public static void Clear()
            {
                hashtable.Clear();
            }

            public static void Vkid()
            {
                hashtable.Add(1, "четыре");
                hashtable.Add(6, "чатыре");
                hashtable.Add(7, "чятыре");
                hashtable.Add(3, "читыре");
                hashtable.Add(8, "чутыре");
            }

            public static void Write()
            {
                foreach (int key in hashtable.Keys)
                {
                    Console.WriteLine($"{key}: {hashtable[key]}");
                }
            }
        }

        public class Stack_Methods : Collections_Methods
        {
            static Stack stack = new Stack();
            static Stack stack_check = new Stack();

            public static void Check()
            {
                Console.Clear();
                stack_check.Clear();
                Console.WriteLine("Введите строку для проверки");
                string s = Console.ReadLine();
                string el;
                bool flag = true;
                bool tozhe_flag = false;
                foreach (char ch in s)
                {
                    if (ch == '{' || ch == '[' || ch == '(')
                        stack_check.Push(ch);

                    if (ch == '}' || ch == ']' || ch == ')')
                    {
                        if (stack_check.Count == 0)
                        {
                            flag = false;
                            break;
                        }

                        tozhe_flag = true;
                        el = Convert.ToString(stack_check.Pop());
                        string elch = Convert.ToString(el + ch);
                        if (elch == "{}" || elch == "[]" || elch == "()")
                            continue;
                        else
                            flag = false;
                        break;
                    }
                }

                if (flag && tozhe_flag)
                    Console.WriteLine("Скобки расставлены верно");
                else
                    Console.WriteLine("Скобки расставлены неверно или скобок нет");


                Console.WriteLine("Нажмите любую клавишу");
                Console.ReadKey();
                Console.Clear();
            }

            public static void Contains()
            {
                Console.Clear();

                if (stack.Contains("ааа"))
                    Console.WriteLine("В стек входит элемент 'ааа'");
                else
                    Console.WriteLine("В стек не входит элемент 'ааа'");

                Console.WriteLine("Нажмите любую клавишу");
                Console.ReadKey();

                Console.Clear();
            }

            public static void Clear()
            {
                stack.Clear();

            }

            public static void Push()
            {
                Console.Clear();
                while (true)
                {
                    Console.WriteLine("Введите элемент для добавления");
                    string element = Console.ReadLine();
                    stack.Push(element);
                    Console.WriteLine("Добавить ещё?");
                    string answer = Console.ReadLine();
                    if (answer == "да" || answer == "Да" || answer == "yes" || answer == "Yes")
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                Console.Clear();
            }

            public static void Pop()
            {
                stack.Pop();
            }

            public static void Count()
            {
                Console.Clear();
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Длина массива: {0} элементов", stack.Count);

                Console.WriteLine("Нажмите любую клавишу");
                Console.ReadKey();

                Console.Clear();
            }
            public static void Write()
            {
                Console.Write($"Stack: [{String.Join(", ", stack.ToArray())}]");

            }
        }

        public class Queue_Methods : Collections_Methods
        {
            static Queue queue = new Queue();

            public static void Contains()
            {
                Console.Clear();

                if (queue.Contains("ааа"))
                    Console.WriteLine("В очередь входит элемент 'ааа'");
                else
                    Console.WriteLine("В очередь не входит элемент 'ааа'");

                Console.WriteLine("Нажмите любую клавишу");
                Console.ReadKey();

                Console.Clear();
            }

            public static void Clear()
            {
                queue.Clear();

            }

            public static void Enqueue()
            {
                Console.Clear();
                while (true)
                {
                    Console.WriteLine("Введите элемент для добавления");
                    string element = Console.ReadLine();
                    queue.Enqueue(element);
                    Console.WriteLine("Добавить ещё?");
                    string answer = Console.ReadLine();
                    if (answer == "да" || answer == "Да" || answer == "yes" || answer == "Yes")
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                Console.Clear();
            }

            public static void Dequeue()
            {
                queue.Dequeue();
            }

            public static void Count()
            {
                Console.Clear();
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Длина очереди: {0} элементов", queue.Count);

                Console.WriteLine("Нажмите любую клавишу");
                Console.ReadKey();

                Console.Clear();
            }

            public static void Write()
            {
                Console.Write($"Queue: [{String.Join(", ", queue.ToArray())}]");

            }
        }

        public class Dict_Methods
        {
            public static Dictionary<int, string> dict = new Dictionary<int, string>();

            public static void Vkid()
            {
                dict.Add(1, "четыре");
                dict.Add(6, "чатыре");
                dict.Add(7, "чятыре");
                dict.Add(3, "читыре");
                dict.Add(8, "чутыре");
            }

            public static void Write()
            {

                foreach (int key in dict.Keys)
                {
                    Console.WriteLine($"{key}: {dict[key]}");
                }

            }

            public static void Remove()
            {

                Console.WriteLine("Введите ключ");
                dict.Remove(int.Parse(Console.ReadLine()));

            }

            public static void Count()
            {

                Console.WriteLine(dict.Count());
                Thread.Sleep(1000);

            }

            public static void Clear()
            {
                dict.Clear();
            }

            public static void Last()
            {
                Console.WriteLine(dict.Last());
                Thread.Sleep(1000);
            }

            public static void Add()
            {
                Console.WriteLine("Введите новый ключ");
                int key = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите значение");
                dict.Add(key, Console.ReadLine());
            }

            public static void First()
            {
                Console.WriteLine(dict.First());
                Thread.Sleep(1000);

            }

            public static void GettType()
            {
                Console.WriteLine(dict.GetType());
                Thread.Sleep(1000);
            }

            public static void Elements()
            {
                Console.WriteLine("Введите индекс");
                KeyValuePair<int, string> pair = dict.ElementAt(int.Parse(Console.ReadLine()));
                Console.WriteLine($"{pair.Key}:{pair.Value}");
                Thread.Sleep(1000);
            }

        }

        public class List_Methods
        {
            static List<int> list = new List<int> { 1, 11, 4, -1 }; 

            public static void Write()
            {
                foreach(var obj in list)
                    Console.Write(obj+" ");
            }

            public static void Add()
            {
                Console.WriteLine("Введите число");
                list.Add(int.Parse(Console.ReadLine()));
            }

            public static void Clear()
            {
                list.Clear();
            }

            public static void Reverse()
            {
                list.Reverse();
            }

            public static void Count()
            {
                Console.WriteLine(list.Count);
                Thread.Sleep(1000);
            }

            public static void Sort()
            {
                list.Sort();
            }

            public static void First()
            {
                Console.WriteLine(list.First());
                Thread.Sleep(1000);
            }

            public static void Last()
            {
                Console.WriteLine(list.Last());
                Thread.Sleep(1000);
            }

            public static void Remove()
            {
                Console.WriteLine("Введите, шо хотите удалить");
                list.Remove(int.Parse(Console.ReadLine()));
            }

        }

        public class SortedList_Methods
        {
            static SortedList<int, string> sortedlist = new SortedList<int, string>();

            public static void Vkid()
            {
                sortedlist.Add(1, "хто");
                sortedlist.Add(-1, "я?");
                sortedlist.Add(5, "чатыре");
                sortedlist.Add(4, "ни чатыре");
            }

            public static void Write()
            {
                foreach (var obj in sortedlist)
                    Console.WriteLine($"{obj.Key}:{obj.Value}");
            }

            public static void Add()
            {
                Console.WriteLine("Введите число");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите значение");
                sortedlist.Add(num, Console.ReadLine());
            }

            public static void Remove()
            {
                Console.WriteLine("Введите ключ");
                int num = int.Parse(Console.ReadLine());
                sortedlist.Remove(num);
            }

            public static void Clear()
            {
                sortedlist.Clear();
            }

            public static void Count()
            {
                Console.WriteLine(sortedlist.Count());
                Thread.Sleep(1000);
            }

            public static void First()
            {
                Console.WriteLine(sortedlist.First());
                Thread.Sleep(1000);
            }
            public static void Last()
            {
                Console.WriteLine(sortedlist.Last());
                Thread.Sleep(1000);
            }

            public static void GettType()
            {
                Console.WriteLine(sortedlist.GetType());
                Thread.Sleep(1000);
            }

            public static void ElementAt()
            {
                Console.WriteLine("Введите индекс элемента");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine(sortedlist.ElementAt(num));
                Thread.Sleep(1000);
            }

        }

        public class HashSet_Methods
        {
            static HashSet<string> hashset = new HashSet<string> { "адын", "васемнацат", "чатыре", "тэри" };

            public static void Write()
            {
                foreach (var obj in hashset)
                    Console.Write(obj+" ");
            }

            public static void Add()
            {
                Console.WriteLine("Введите што-нибудь");
                hashset.Add(Console.ReadLine());
            }

            public static void Remove()
            {
                Console.WriteLine("Введите что удалить");
                hashset.Remove(Console.ReadLine());
            }

            public static void Clear()
            {
                hashset.Clear();
            }

            public static void Count()
            {
                Console.WriteLine(hashset.Count());
                Thread.Sleep(1000);
            }

            public static void First()
            {
                Console.WriteLine(hashset.First());
                Thread.Sleep(1000);
            }
            public static void Last()
            {
                Console.WriteLine(hashset.Last());
                Thread.Sleep(1000);
            }

            public static void GettType()
            {
                Console.WriteLine(hashset.GetType());
                Thread.Sleep(1000);
            }

            public static void ElementAt()
            {
                Console.WriteLine("Введите индекс элемента");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine(hashset.ElementAt(num));
                Thread.Sleep(1000);
            }

        }

        public class SortedSet_Methods
        {
            static SortedSet<string> sortedset = new SortedSet<string> { "адын", "васемнацат", "чатыре", "тэри" };

            public static void Write()
            {
                foreach (var obj in sortedset)
                    Console.Write(obj + " ");
            }

            public static void Add()
            {
                Console.WriteLine("Введите што-нибудь");
                sortedset.Add(Console.ReadLine());
            }

            public static void Remove()
            {
                Console.WriteLine("Введите что удалить");
                sortedset.Remove(Console.ReadLine());
            }

            public static void Clear()
            {
                sortedset.Clear();
            }

            public static void Count()
            {
                Console.WriteLine(sortedset.Count());
                Thread.Sleep(1000);
            }

            public static void First()
            {
                Console.WriteLine(sortedset.First());
                Thread.Sleep(1000);
            }
            public static void Last()
            {
                Console.WriteLine(sortedset.Last());
                Thread.Sleep(1000);
            }

            public static void GettType()
            {
                Console.WriteLine(sortedset.GetType());
                Thread.Sleep(1000);
            }

            public static void ElementAt()
            {
                Console.WriteLine("Введите индекс элемента");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine(sortedset.ElementAt(num));
                Thread.Sleep(1000);
            }

        }
        static void Main(string[] args)
        {
            
        }
    }
}