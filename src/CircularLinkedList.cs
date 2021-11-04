using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Lab_3
{
    public class CircularLinkedList<T> : ICollection<T>
    {
        Node<T> head;
        Node<T> tail;
        private int count;
        public int Count { get { return count; } }
        public bool IsEmpty => Count == 0 ? true : false;

        public bool IsReadOnly => false;
        public T this[int index]
        {
            get
            {
                if (index < count && index >= 0)
                {
                    Node<T> node = head;
                    while (index != 0)
                    {
                        node = node.Next;
                        index--;
                    }
                    return node.Data;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }
        public void Add(T item)
        {
            Node<T> node = new Node<T>(item);

            if (head == null)
            {
                head = node;
                tail = node;
                tail.Next = head;
            }
            else
            {
                node.Next = head;
                tail.Next = node;
                tail = node;
            }
            count++;
        }

        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public bool Contains(T item)
        {
            Node<T> current = head;
            if (current == null) return false;
            do
            {
                if (current.Data.Equals(item))
                    return true;
                current = current.Next;
            }
            while (current != head);
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            if (arrayIndex >= 0 && arrayIndex < count)
            {
                int it = 0;
                foreach (var el in this)
                {
                    if (arrayIndex <= 0)
                    {
                        array[it] = el;
                        it++;
                    }
                    arrayIndex--;
                }
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
        public void Show()
        {
            foreach (var el in this)
                Console.WriteLine(el.ToString());
        }
        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = head;
            do
            {
                if (current != null)
                {
                    yield return current.Data;
                    current = current.Next;
                }
            }
            while (current != head);
        }

        public bool Remove(T item)
        {
            Node<T> current = head;
            Node<T> previous = null;

            if (IsEmpty) return false;

            do
            {
                if (current.Data.Equals(item))
                {
                    
                    if (previous != null)
                    {
                        
                        previous.Next = current.Next;

                        
                        if (current == tail)
                            tail = previous;
                    }
                    else
                    {
                        if (count == 1)
                        {
                            head = tail = null;
                        }
                        else
                        {
                            head = current.Next;
                            tail.Next = current.Next;
                        }
                    }
                    count--;
                    return true;
                }

                previous = current;
                current = current.Next;
            } while (current != head);

            return false;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }
    }

    internal class Node<T>
    {
        public Node(T data)
        {
            Data = data;
        }
        public T Data { get; set; }
        public Node<T> Next { get; set; }
    }
}

