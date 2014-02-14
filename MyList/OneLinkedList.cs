/*
 * Сделано в SharpDevelop.
 * Пользователь: Лектор
 * Дата: 11.02.2014
 * Время: 10:40
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;
using System.Collections;

namespace MyList
{
	/// <summary>
	/// Description of OneLinkedList.
	/// </summary>
	public class OneLinkedList<T> : IEnumerable  
	{
		// голова списка
		protected Node<T> head;
		// хвост
		protected Node<T> tail;		
		
		public OneLinkedList()
		{
			head = tail = null;
		}
		// добавляем функционал
		
		public void Add(T val)
		{
			// 1) - новый узел
			var node = new Node<T>(val);  
			if (tail == null)
			{
				head = tail = node;
				return;				
			}
			// 2) прицепляем узел к хвосту
			tail.Next = node;
			// 3) шаг = новый узел становится
			// хвостом
			tail = node;
		}
		
		public IEnumerator GetEnumerator()
		{
			return new MyIterator<T>(this);
		}
        public class MyIterator<T> : IEnumerator
        {
            private OneLinkedList<T> list;
            private Node<T> cur;

            public MyIterator(OneLinkedList<T> List)
            {
                this.list = List;
                this.cur = null;
            }
            public object Current
            {
                get { return this.cur.Content; }
            }
            public bool MoveNext()
        {
            if (cur == null)
            {
                cur = this.list.head;
                return true;
            }
            cur = cur.Next;
            if (cur == null)
                return false;
            else return true;
        }
            public void Reset()
            {
                cur = null;
            }
        }
	}
}
