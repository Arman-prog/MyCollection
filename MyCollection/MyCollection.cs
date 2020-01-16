using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCollection
{
    public class MyCollection<T> : ICollection<T>
    {
        private MyCollection<T> First;
        private MyCollection<T> Next;
        private T value;

        public MyCollection(T value)
        {
            this.value = value;
        }
        public MyCollection()
        {

        }

        public int Count { get; private set; }

        public bool IsReadOnly => false;

        public void Add(T item)
        {
            MyCollection<T> temp = new MyCollection<T>(item);
            if (First == null)
            {
                First = temp;
                Count++;
            }
            else if (First.Next == null)
            {
                First.Next = temp;
                Count++;
            }
            else
            {
                MyCollection<T> node = First;
                while (node != null)
                {
                    if (node.Next == null)
                    {
                        node.Next = temp;
                        Count++;
                        return;
                    }
                    node = node.Next;
                }
            }

        }

        public void Clear()
        {
            First = null;
            Count = 0;
        }

        public bool Contains(T item)
        {
            if (First == null)
            {
                throw new NullReferenceException();
            }
            MyCollection<T> temp = First;
            while (temp != null)
            {
                if (temp.value.Equals(item))
                {
                    return true;
                }
                temp = temp.Next;
            }
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            MyCollection<T> temp = First;
            while (temp != null)
            {
                yield return temp.value;
                temp = temp.Next;
            }
        }

        public bool Remove(T item)
        {
            if (Contains(item))
            {
                if (First.value.Equals(item))
                {
                    First = First.Next;
                    Count--;
                    return true;
                }
                MyCollection<T> temp = First;
                MyCollection<T> nexttemp = temp.Next;
                while (temp != null)
                {
                    if (temp.Next.value.Equals(item))
                    {
                        if (nexttemp == null)
                        {
                            temp = null;
                            Count--;
                            return true;
                        }
                        else
                        {
                            temp.Next = nexttemp.Next;
                            Count--;
                            return true;
                        }

                    }
                    temp = temp.Next;
                    if (nexttemp.Next != null)
                    {
                        nexttemp = nexttemp.Next;
                    }
                }
                return false;
            }
            else
            {
                return false;
            }
        }

        public void Print()
        {
            PrintPrivate(First);
        }
        private void PrintPrivate(MyCollection<T> item)
        {
            MyCollection<T> temp = item;
            while (temp != null)
            {
                Console.WriteLine(temp.value);
                temp = temp.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }


    }
}
