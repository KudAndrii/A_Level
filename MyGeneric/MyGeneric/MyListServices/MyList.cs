using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyGeneric.Interfaces;

namespace MyGeneric.MyListServices
{
    internal class MyList<T> : IMyList<T>
    {
        private const int STARTLENGTH = 16;
        private T[] _list;
        private int _emptyIndex;
        public MyList()
        {
            _list = new T[STARTLENGTH];
            _emptyIndex = 0;
        }

        public MyList(T item)
            : this()
        {
            Add(item);
        }

        public MyList(T[] items)
        {
            if (items.Length > STARTLENGTH)
            {
                _list = new T[items.Length * 2];
            }
            else
            {
                _list = new T[STARTLENGTH];
            }

            AddRange(items);
        }

        public T[] List
        {
            get
            {
                return CopyIntoNewList(_emptyIndex);
            }
        }

        public void Add(T element)
        {
            CheckLength(_emptyIndex);
            _list[_emptyIndex] = element;
            _emptyIndex++;
        }

        public void AddRange(T[] elements)
        {
            CheckLength(_emptyIndex + elements.Length);
            for (int i = 0; i < elements.Length; i++)
            {
                _list[_emptyIndex + i] = elements[i];
            }

            _emptyIndex += elements.Length;
        }

        public void Remove(T element, out bool result)
        {
        }

        public void RemoveAt(int index)
        {
        }

        public void Sort()
        {
        }

        private T[] CopyIntoNewList(int length)
        {
            T[] result = new T[length];
            for (int i = 0; i < length; i++)
            {
                result[i] = _list[i];
            }

            return result;
        }

        private void CheckLength(int length)
        {
            if (_list.Length <= length)
            {
                _list = CopyIntoNewList(_list.Length * 2);
            }
        }
    }
}
