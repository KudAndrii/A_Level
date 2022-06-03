using System;
using System.Collections;
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

        /// <summary>
        /// Method sorts the elements in a range of elements in an System.Array using the System.IComparable`1
        /// generic interface implementation of each element of the System.Array.
        /// </summary>
        public void Sort();

        /// <summary>
        /// Method sorts the elements in a range of elements in a one-dimensional System.Array using
        /// the specified System.Collections.IComparer.
        /// </summary>
        /// <param name="comparer">The System.Collections.IComparer implementation to use when comparing elements.
        /// -or- null to use the System.IComparable implementation of each element.</param>
        public void Sort(IComparer comparer);
    }
}
