using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyGeneric.Interfaces;

namespace MyGeneric.MyListServices
{
    internal class MyList<T> : IMyList<T>, IEnumerable
    {
        /// <summary>
        /// Start lenght of _list.
        /// </summary>
        private const int _startLength = 16;

        /// <summary>
        /// First empty element in _list.
        /// </summary>
        private int _emptyIndex;

        private T[] _list;

        public MyList()
        {
            _list = new T[_startLength];
            _emptyIndex = 0;
        }

        public MyList(T item)
            : this()
        {
            Add(item);
        }

        public MyList(T[] items)
        {
            if (items.Length > _startLength)
            {
                _list = new T[items.Length * 2];
            }
            else
            {
                _list = new T[_startLength];
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

        /// <summary>
        /// Iterator implementation.
        /// </summary>
        /// <returns>All filled elements.</returns>
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < _emptyIndex; i++)
            {
                yield return _list[i];
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
            result = false;
            for (int i = 0; i < _list.Length; i++)
            {
                if (_list[i].Equals(element))
                {
                    result = true;
                    RemoveAt(i);
                    break;
                }
            }
        }

        public void RemoveAt(int index)
        {
            T[] result = new T[_list.Length];
            int j = 0;
            for (int i = 0; i < _list.Length; i++)
            {
                if (i == index)
                {
                    continue;
                }
                else
                {
                    result[j] = _list[i];
                    j++;
                }
            }

            _list = result;
            _emptyIndex--;
        }

        public void Sort()
        {
            Array.Sort(_list, 0, _emptyIndex);
        }

        public void Sort(IComparer comparer)
        {
            Array.Sort(_list, 0, _emptyIndex, comparer);
        }

        /// <summary>
        /// Method returns generic array from first element to specified element.
        /// </summary>
        /// <param name="length">Specified element.</param>
        /// <returns>Generic array.</returns>
        private T[] CopyIntoNewList(int length)
        {
            T[] result = new T[length];
            for (int i = 0; i < length; i++)
            {
                result[i] = _list[i];
            }

            return result;
        }

        /// <summary>
        /// Method doubles lenght of _list if specified lenght less then _list.Lenght.
        /// </summary>
        /// <param name="length">Specified lenght for comparison.</param>
        private void CheckLength(int length)
        {
            if (_list.Length <= length)
            {
                _list = CopyIntoNewList(_list.Length * 2);
            }
        }
    }
}
