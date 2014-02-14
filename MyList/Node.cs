/*
 * Сделано в SharpDevelop.
 * Пользователь: Лектор
 * Дата: 11.02.2014
 * Время: 10:33
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;

namespace MyList
{
	/// <summary>
	/// Обобщенный класс - узел списка
	/// </summary>
	public class Node<T>
	{
		public T Content {get; set;}
		public Node<T> Next {get;set;}
		
		public Node(T value)
		{
			Content = value;
			Next = null;
		}
	}
}
