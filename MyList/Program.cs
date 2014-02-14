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

            var list = new OneLinkedList<string>();
            list.Add("пашка");
			list.Add("привет");
			list.Add("как дела");
			list.Add("хорошо");
			list.Add("пока");

            string st = list[0];
            list[1] = "good bye";


			foreach (var s in list) 
			{
				Console.WriteLine(s);
            }

            Console.WriteLine();
            list.Remove("как дела");

            foreach (var s in list)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("\r\nДЗ: Добавить методы Instert(n,val), RemoveAt(i), RemoveAll(entry)");
			Console.ReadKey(true);
		}
	}
}