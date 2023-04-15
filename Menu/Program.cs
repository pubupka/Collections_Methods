using static Collections.Collections_Methods;
using static Wishes.Wishes;

namespace Menu
{
    public class Menu
    {
        static int Move(int i, int n, ConsoleKeyInfo key)
        {
            if (key.Key == ConsoleKey.UpArrow)
            {
                i = (n + i - 1) % n;
            }

            if (key.Key == ConsoleKey.DownArrow)
            {
                i = (i + 1) % n;
            }

            return i;
        }

        static void ClearLine(int line) => Console.MoveBufferArea(0, line, Console.BufferWidth, 1, Console.BufferWidth, line, ' ', Console.ForegroundColor, Console.BackgroundColor);


        public static void Main_Menu()
        {
            int i = 0;
            int n = 11;

            while (true)
            {
                Console.CursorVisible = false;
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Array");
                Console.WriteLine("ArrayList");
                Console.WriteLine("HashTable");
                Console.WriteLine("Stack");
                Console.WriteLine("Queue");
                Console.WriteLine("Dict");
                Console.WriteLine("List");
                Console.WriteLine("SortedList");
                Console.WriteLine("HashSet");
                Console.WriteLine("SortedSet");
                Console.WriteLine("Завершить работу");
                Console.SetCursorPosition(40, i);
                Console.CursorVisible = true;

                ConsoleKeyInfo key = Console.ReadKey();

                if (key.Key == ConsoleKey.Enter)
                {
                    switch (i)
                    {
                        case 0:
                            Array_Menu();
                            break;
                        case 1:
                            ArrayList_Menu();
                            break;
                        case 2:
                            HashTable_Menu();
                            break;
                        case 3:
                            Stack_Menu();
                            break;
                        case 4:
                            Queue_Menu();
                            break;
                        case 5:
                            Dict_Menu();
                            break;
                        case 6:
                            List_Menu();
                            break;
                        case 7:
                            SortedList_Menu();
                            break;
                        case 8:
                            HashSet_Menu();
                            break;
                        case 9:
                            SortedSet_Menu();
                            break;
                        default:
                            break;
                    }
                }

                if (i == 10 && key.Key == ConsoleKey.Enter)
                {
                    break;
                }

                i = Move(i, n, key);
            }

            GetWish();
        }
        static void Array_Menu()
        {
            int i = 0, n = 10;
            Console.Clear();

            while (true)
            {
                Console.CursorVisible = false;
                Console.SetCursorPosition(0, 11);
                Console.ForegroundColor = ConsoleColor.Red;
                ClearLine(11);
                Array_Methods.Write();

                Console.SetCursorPosition(0, 0);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Отсортировать по возрастанию"); //Sort
                Console.WriteLine("Перевернуть"); // Reverse
                Console.WriteLine("Бинарный поиск"); // BinarySearch
                Console.WriteLine("Очистить"); // Clear
                Console.WriteLine("Установить значение"); // SetValue
                Console.WriteLine("Индекс первого вхождения элемента"); // IndexOf
                Console.WriteLine("Индекс последнего вхождения элемента"); // LastIndexOf
                Console.WriteLine("Получить значение по индексу"); // GetValue
                Console.WriteLine("Длина массива"); // Это вообще свойство, но я не знаю, что ещё добавить
                Console.WriteLine("Назад");
                Console.SetCursorPosition(40, i);
                Console.CursorVisible = true;

                ConsoleKeyInfo key = Console.ReadKey();

                if (key.Key == ConsoleKey.Enter)
                {
                    switch (i)
                    {
                        case 0:
                            Array_Methods.Sort();
                            break;
                        case 1:
                            Array_Methods.Reverse();
                            break;
                        case 2:
                            Array_Methods.BinarySearch();
                            break;
                        case 3:
                            Array_Methods.Clear();
                            break;
                        case 4:
                            Array_Methods.SetValue();
                            break;
                        case 5:
                            Array_Methods.IndexOf();
                            break;
                        case 6:
                            Array_Methods.LastIndexOf();
                            break;
                        case 7:
                            Array_Methods.GetValue();
                            break;
                        case 8:
                            Array_Methods.Length();
                            break;
                    }
                }
                if (i == 9 && key.Key == ConsoleKey.Enter)
                {
                    break;
                }

                i = Move(i, n, key);
            }
            Console.Clear();
        }
        static void ArrayList_Menu()
        {
            int i = 0, n = 10;
            Console.Clear();

            while (true)
            {
                Console.CursorVisible = false;
                Console.SetCursorPosition(0, 11);
                Console.ForegroundColor = ConsoleColor.Red;
                ClearLine(11);
                ArrayList_Methods.Write();

                Console.SetCursorPosition(0, 0);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Отсортировать по возрастанию"); //Sort
                Console.WriteLine("Перевернуть"); // Reverse
                Console.WriteLine("Бинарный поиск"); // BinarySearch
                Console.WriteLine("Очистить"); // Clear
                Console.WriteLine("Добавить элемент"); // Add
                Console.WriteLine("Индекс первого вхождения элемента"); // IndexOf
                Console.WriteLine("Индекс последнего вхождения элемента"); // LastIndexOf
                Console.WriteLine("Удалить первое вхождения элемента"); // Remove
                Console.WriteLine("Длина массива"); // Это вообще свойство, но я не знаю, что ещё добавить
                Console.WriteLine("Назад");
                Console.SetCursorPosition(40, i);
                Console.CursorVisible = true;

                ConsoleKeyInfo key = Console.ReadKey();

                if (key.Key == ConsoleKey.Enter)
                {
                    switch (i)
                    {
                        case 0:
                            ArrayList_Methods.Sort();
                            break;
                        case 1:
                            ArrayList_Methods.Reverse();
                            break;
                        case 2:
                            ArrayList_Methods.BinarySearch();
                            break;
                        case 3:
                            ArrayList_Methods.Clear();
                            break;
                        case 4:
                            ArrayList_Methods.Add();
                            break;
                        case 5:
                            ArrayList_Methods.IndexOf();
                            break;
                        case 6:
                            ArrayList_Methods.LastIndexOf();
                            break;
                        case 7:
                            ArrayList_Methods.Remove();
                            break;
                        case 8:
                            ArrayList_Methods.Length();
                            break;
                    }
                }

                if (i == 9 && key.Key == ConsoleKey.Enter)
                {
                    break;
                }

                i = Move(i, n, key);
            }
            Console.Clear();
        }

        static void HashTable_Menu()
        {
            int i = 0, n = 9;
            Console.Clear();
            HashTable_Methods.Vkid();

            while (true)
            {
                Console.CursorVisible = false;
                Console.SetCursorPosition(0, 10);
                Console.ForegroundColor = ConsoleColor.Red;
                for (int l = 10; l < 21; l++)
                    ClearLine(l);
                HashTable_Methods.Write();

                Console.SetCursorPosition(0, 0);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Очистить"); // Clear
                Console.WriteLine("Добавить элемент"); // Add
                Console.WriteLine("Удалить элемент"); // Remove
                Console.WriteLine("Размер таблицы"); // Это вообще свойство, но я не знаю, что ещё добавить
                Console.WriteLine("Показать ключи"); //.Keys
                Console.WriteLine("Показать значения"); //.Values
                Console.WriteLine("Проверить наличие ключа 1"); //hashtable.ContainsKey(1)
                Console.WriteLine("Проверить наличие значения чатыре"); //hashtable.ContainsValue(3)
                Console.WriteLine("Назад");
                Console.SetCursorPosition(40, i);
                Console.CursorVisible = true;

                ConsoleKeyInfo key = Console.ReadKey();

                if (key.Key == ConsoleKey.Enter)
                {
                    switch (i)
                    {
                        case 0:
                            HashTable_Methods.Clear();
                            break;
                        case 1:
                            HashTable_Methods.Add();
                            break;
                        case 2:
                            HashTable_Methods.Remove();
                            break;
                        case 3:
                            HashTable_Methods.Count();
                            break;
                        case 4:
                            HashTable_Methods.Keys();
                            break;
                        case 5:
                            HashTable_Methods.Values();
                            break;
                        case 6:
                            HashTable_Methods.ContainsKey();
                            break;
                        case 7:
                            HashTable_Methods.ContainsValue();
                            break;
                    }
                }
                if (i == 8 && key.Key == ConsoleKey.Enter)
                {
                    break;
                }
                i = Move(i, n, key);
            }
            Console.Clear();
        }

        static void Stack_Menu()
        {
            int i = 0, n = 9;
            Console.Clear();

            while (true)
            {
                Console.CursorVisible = false;
                Console.SetCursorPosition(0, 8);
                Console.ForegroundColor = ConsoleColor.Red;
                ClearLine(8);
                Stack_Methods.Write();

                Console.SetCursorPosition(0, 0);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Очистить"); // Clear
                Console.WriteLine("Добавить элемент"); // Push
                Console.WriteLine("Удалить элемент"); // Pop
                Console.WriteLine("Проверить расстановку скобок"); //Check
                Console.WriteLine("Размер стека"); // Это вообще свойство, но я не знаю, что ещё добавить
                Console.WriteLine("Проверить наличие элемента 'ааа' (на русском)"); //.Contains("aaa")
                Console.WriteLine("Назад");
                Console.SetCursorPosition(40, i);
                Console.CursorVisible = true;

                ConsoleKeyInfo key = Console.ReadKey();

                if (key.Key == ConsoleKey.Enter)
                {
                    switch (i)
                    {
                        case 0:
                            Stack_Methods.Clear();
                            break;
                        case 1:
                            Stack_Methods.Push();
                            break;
                        case 2:
                            Stack_Methods.Pop();
                            break;
                        case 3:
                            Stack_Methods.Check();
                            break;
                        case 4:
                            Stack_Methods.Count();
                            break;
                        case 5:
                            Stack_Methods.Contains();
                            break;
                    }
                }
                if (i == 7 && key.Key == ConsoleKey.Enter)
                {
                    break;
                }
                i = Move(i, n, key);
            }
            Console.Clear();
        }

        static void Queue_Menu()
        {
            int i = 0, n = 9;
            Console.Clear();

            while (true)
            {
                Console.CursorVisible = false;
                Console.SetCursorPosition(0, 8);
                Console.ForegroundColor = ConsoleColor.Red;
                ClearLine(8);
                Queue_Methods.Write();

                Console.SetCursorPosition(0, 0);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Очистить"); // Clear
                Console.WriteLine("Добавить элемент"); // Enqueue
                Console.WriteLine("Удалить элемент"); // Dequeue
                Console.WriteLine("Размер очереди"); // Это вообще свойство, но я не знаю, что ещё добавить
                Console.WriteLine("Проверить наличие элемента 'ааа' (на русском)"); //.Contains("aaa")
                Console.WriteLine("Назад");
                Console.SetCursorPosition(40, i);
                Console.CursorVisible = true;

                ConsoleKeyInfo key = Console.ReadKey();

                if (key.Key == ConsoleKey.Enter)
                {
                    switch (i)
                    {
                        case 0:
                            Queue_Methods.Clear();
                            break;
                        case 1:
                            Queue_Methods.Enqueue();
                            break;
                        case 2:
                            Queue_Methods.Dequeue();
                            break;
                        case 3:
                            Queue_Methods.Count();
                            break;
                        case 4:
                            Queue_Methods.Contains();
                            break;
                    }
                }
                if (i == 5 && key.Key == ConsoleKey.Enter)
                {
                    break;
                }
                i = Move(i, n, key);
            }
            Console.Clear();
        }

        static void Dict_Menu()
        {
            Console.Clear();
            int i = 0, n = 9;
            Dict_Methods.Vkid();
            while (true)
            {
                Console.CursorVisible = false;
                Console.SetCursorPosition(0, 11);
                Console.ForegroundColor = ConsoleColor.Red;
                for (int l = 10; l < 21; l++)
                    ClearLine(l);
                Dict_Methods.Write();


                Console.SetCursorPosition(0, 0);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Удалить пару ключ-значение по ключу"); //remove
                Console.WriteLine("Выдать количество пар ключ-значение"); //Count
                Console.WriteLine("Очистить"); //clear
                Console.WriteLine("Выдать значение последнего ключа"); //Last
                Console.WriteLine("Добавить пару ключ-значение в начало словаря"); //add 
                Console.WriteLine("Выдать значение первого ключа"); // fisrt
                Console.WriteLine("Узнать тип словаря"); // GetType
                Console.WriteLine("Выдать пару ключ-значение по нужному индексу");// elements
                Console.WriteLine("Назад");


                Console.SetCursorPosition(50, i);
                Console.CursorVisible = true;
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.Enter)
                {
                    Console.Clear();

                    switch (i)
                    {
                        case 0:
                            Dict_Methods.Remove();
                            break;
                        case 1:
                            Dict_Methods.Count();
                            break;
                        case 2:
                            Dict_Methods.Clear();
                            break;
                        case 3:
                            Dict_Methods.Last();
                            break;
                        case 4:
                            Dict_Methods.Add();
                            break;
                        case 5:
                            Dict_Methods.First();
                            break;
                        case 6:
                            Dict_Methods.GettType();
                            break;
                        case 7:
                            Dict_Methods.Elements();
                            break;
                        default:
                            break;
                    }

                    Console.Clear();
                    if (i == 8)
                        break;
                }
                else i=Move(i, n, key);

            }
        }

        static void List_Menu()
        {
            Console.Clear();
            int i = 0, n = 9;

            while (true)
            {
                Console.CursorVisible = false;
                Console.SetCursorPosition(0, 11);
                Console.ForegroundColor = ConsoleColor.Red;
                ClearLine(11);
                List_Methods.Write();


                Console.SetCursorPosition(0, 0);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Добавить элемент"); //add
                Console.WriteLine("Очистить список"); //clear
                Console.WriteLine("Перевернуть список"); //reverse
                Console.WriteLine("Выдать кол-во элементов списка"); // count
                Console.WriteLine("Отсортировать по возрастанию"); //sort
                Console.WriteLine("Выдать первый элемент"); // first
                Console.WriteLine("Выдать последний элемент"); //last
                Console.WriteLine("Удалить элемент");//remove
                Console.WriteLine("Назад");


                Console.SetCursorPosition(50, i);
                Console.CursorVisible = true;
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.Enter)
                {
                    Console.Clear();

                    switch (i)
                    {
                        case 0:
                            List_Methods.Add();
                            break;
                        case 1:
                            List_Methods.Clear();
                            break;
                        case 2:
                            List_Methods.Reverse();
                            break;
                        case 3:
                            List_Methods.Count();
                            break;
                        case 4:
                            List_Methods.Sort();
                            break;
                        case 5:
                            List_Methods.First();
                            break;
                        case 6:
                            List_Methods.Last();
                            break;
                        case 7:
                            List_Methods.Remove();
                            break;
                        default:
                            break;
                    }

                    Console.Clear();
                    if (i == 8)
                        break;
                }
                else i = Move(i, n, key);

            }
        }


        static void SortedList_Menu()
        {
            Console.Clear();
            int i = 0, n = 9;
            SortedList_Methods.Vkid();

            while (true)
            {
                Console.CursorVisible = false;
                Console.SetCursorPosition(0, 11);
                Console.ForegroundColor = ConsoleColor.Red;
                for (int l = 10; l < 21; l++)
                    ClearLine(l);
                SortedList_Methods.Write();


                Console.SetCursorPosition(0, 0);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Добавить пару ключ-значение"); //Add
                Console.WriteLine("Удалить пару ключ-значение"); //Remove
                Console.WriteLine("Очистить сортированный список"); //Clear
                Console.WriteLine("Выдать количество элементов в сортированном списке"); //Count
                Console.WriteLine("Выдать первую пару ключ-значение"); //first
                Console.WriteLine("Выдать последнюю пару ключ-значение"); // last
                Console.WriteLine("Выдать тип этого списка"); //GetType
                Console.WriteLine("Выдать элемент под определённым индексом");//elementAt
                Console.WriteLine("Назад");


                Console.SetCursorPosition(50, i);
                Console.CursorVisible = true;
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.Enter)
                {
                    Console.Clear();

                    switch (i)
                    {
                        case 0:
                            SortedList_Methods.Add();
                            break;
                        case 1:
                            SortedList_Methods.Remove();
                            break;
                        case 2:
                            SortedList_Methods.Clear();
                            break;
                        case 3:
                            SortedList_Methods.Count();
                            break;
                        case 4:
                            SortedList_Methods.First();
                            break;
                        case 5:
                            SortedList_Methods.Last();
                            break;
                        case 6:
                            SortedList_Methods.GettType();
                            break;
                        case 7:
                            SortedList_Methods.ElementAt();
                            break;
                        default:
                            break;
                    }

                    Console.Clear();
                    if (i == 8)
                        break;
                }
                else i = Move(i, n, key);

            }
        }

        static void HashSet_Menu()
        {
            Console.Clear();
            int i = 0, n = 9;

            while (true)
            {
                Console.CursorVisible = false;
                Console.SetCursorPosition(0, 11);
                Console.ForegroundColor = ConsoleColor.Red;
                ClearLine(11);
                HashSet_Methods.Write();


                Console.SetCursorPosition(0, 0);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Добавить значение"); //Add
                Console.WriteLine("Удалить значение"); //Remove
                Console.WriteLine("Очистить множество"); //Clear
                Console.WriteLine("Выдать количество элементов в хеш-множестве"); //Count
                Console.WriteLine("Выдать первое значение"); //first
                Console.WriteLine("Выдать последние значение"); // last
                Console.WriteLine("Выдать тип этого множества"); //GetType
                Console.WriteLine("Выдать элемент под определённым индексом");//elementAt


                Console.SetCursorPosition(50, i);
                Console.CursorVisible = true;
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.Enter)
                {
                    Console.Clear();

                    switch (i)
                    {
                        case 0:
                            HashSet_Methods.Add();
                            break;
                        case 1:
                            HashSet_Methods.Remove();
                            break;
                        case 2:
                            HashSet_Methods.Clear();
                            break;
                        case 3:
                            HashSet_Methods.Count();
                            break;
                        case 4:
                            HashSet_Methods.First();
                            break;
                        case 5:
                            HashSet_Methods.Last();
                            break;
                        case 6:
                            HashSet_Methods.GettType();
                            break;
                        case 7:
                            HashSet_Methods.ElementAt();
                            break;
                        default:
                            break;
                    }
                    Console.Clear();
                    if (i == 8)
                        break;
                    }
                
                else i = Move(i, n, key);

            }
        }

        static void SortedSet_Menu()
        {
            Console.Clear();
            int i = 0, n = 9;

            while (true)
            {
                Console.CursorVisible = false;
                Console.SetCursorPosition(0, 11);
                Console.ForegroundColor = ConsoleColor.Red;
                ClearLine(11);
                SortedSet_Methods.Write();


                Console.SetCursorPosition(0, 0);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Добавить значение"); //Add
                Console.WriteLine("Удалить значение"); //Remove
                Console.WriteLine("Очистить множество"); //Clear
                Console.WriteLine("Выдать количество элементов в хеш-множестве"); //Count
                Console.WriteLine("Выдать первое значение"); //first
                Console.WriteLine("Выдать последние значение"); // last
                Console.WriteLine("Выдать тип этого множества"); //GetType
                Console.WriteLine("Выдать элемент под определённым индексом");//elementAt


                Console.SetCursorPosition(50, i);
                Console.CursorVisible = true;
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.Enter)
                {
                    Console.Clear();

                    switch (i)
                    {
                        case 0:
                            SortedSet_Methods.Add();
                            break;
                        case 1:
                            SortedSet_Methods.Remove();
                            break;
                        case 2:
                            SortedSet_Methods.Clear();
                            break;
                        case 3:
                            SortedSet_Methods.Count();
                            break;
                        case 4:
                            SortedSet_Methods.First();
                            break;
                        case 5:
                            SortedSet_Methods.Last();
                            break;
                        case 6:
                            SortedSet_Methods.GettType();
                            break;
                        case 7:
                            SortedSet_Methods.ElementAt();
                            break;
                        default:
                            break;
                    }
                    Console.Clear();
                    if (i == 8)
                        break;
                }

                else i = Move(i, n, key);

            }
        }

        static void Main(string[] args)
            {

            }
        }
    }
