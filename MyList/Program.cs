/*
 * Сделано в SharpDevelop.
 * Пользователь: Лектор
 * Дата: 11.02.2014
 * Время: 10:30
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;

namespace MyList
{
	class Program
	{
		public static void Main(string[] args)
        {
            Console.WriteLine("Домашнее задание.\n   Добавить методы: \n — Insert(n,val), \n — RemoveAt(i), \n — RemoveAll(entry).\n   И свойство\n — Count.");
            Console.WriteLine("\n============================================\n");

            var list = new OneLinkedList<string>();
            list.Add("Пашка");
            list.Add("привет");
			list.Add("как дела");
			list.Add("хорошо");
            list.Add("пока");

            foreach (var s in list)
            {
                Console.WriteLine(s);
            }

            list.Insert(1, "Плетминцев");
            Console.WriteLine("\nlist.Insert(1, \"Плетминцев\")\n");

            foreach (var s in list)
            {
                Console.WriteLine(s);
            }
            list.RemoveAt(3);
            Console.WriteLine("\nlist.RemoveAt(3)\n");

            foreach (var s in list)
            {
                Console.WriteLine(s);
            }

            list.RemoveAll("ка");
            Console.WriteLine("\nlist.RemoveAll(\"ка\")\n");

            foreach (var s in list)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("\nlist.Count.ToString()\n");
            Console.WriteLine(list.Count.ToString());

            /*
            string st = list[0];
            Console.WriteLine("get=" + st);
            Console.WriteLine();
            list[3] = "good bye";

            Console.WriteLine("COUNT:" + list.Count.ToString());

            Console.WriteLine();
            list.Remove("как дела");

            foreach (var s in list)
            {
                Console.WriteLine(s);
            }
             * */
            Console.ReadKey(true);
		}
	}
}