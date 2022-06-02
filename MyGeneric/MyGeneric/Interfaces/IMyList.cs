using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGeneric.Interfaces
{
    public interface IMyList<T>
    {
        /// <summary>
        /// Method adds specified element.
        /// </summary>
        /// <param name="element">Specified element witch should be added.</param>
        public void Add(T element);

        /// <summary>
        /// Method adds collection of specified elements.
        /// </summary>
        /// <param name="elements">Collection of specified elements witch should be added.</param>
        public void AddRange(T[] elements);

        /// <summary>
        /// Method removes first specified element.
        /// </summary>
        /// <param name="element">Specified element witch chould be removed.</param>
        /// <param name="result">Result of removing (suссessful removal = true).</param>
        public void Remove(T element, out bool result);

        /// <summary>
        /// Method removes element by specified index.
        /// </summary>
        /// <param name="index">Specified index.</param>
        public void RemoveAt(int index);


        public void Sort();
    }
}
