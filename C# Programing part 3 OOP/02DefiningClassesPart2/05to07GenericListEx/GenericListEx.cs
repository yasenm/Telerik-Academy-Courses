// Exercise 05 : Write a generic class GenericList<T> that keeps a list of elements of some 
// parametric type T. Keep the elements of the list in an array with fixed capacity which is 
// given as parameter in the class constructor. Implement methods for adding element, accessing
// element by index, removing element by index, inserting element at given position, clearing
// the list, finding element by its value and ToString(). Check all input parameters to
// avoid accessing elements at invalid positions.

// Exercise 06 : Implement auto-grow functionality: when the internal array is full, create a
// new array of double size and move all elements to it.

// Exercise 07 : Create generic methods Min<T>() and Max<T>() for finding the minimal and 
// maximal element in the  GenericList<T>. You may need to add a generic constraints for the type T.

namespace _05to07GenericListEx
{
    using System;

    class GenericListEx
    {
        // class GenericList is in the file GenericListT
        static void Main()
        {
            GenericList<int> someList = new GenericList<int>();
            someList.Add(2);
            someList.Add(3);
            someList.Add(2);
            someList.Add(1);
            someList.Add(5);
            Console.WriteLine(someList.ToString());
            // first implemented functionality in the current program code below the Main() method
            Console.WriteLine(Min<int>(someList));
            Console.WriteLine(Max<int>(someList));
            // second implemented functionality in the GenericList class as a static method
            Console.WriteLine(GenericList<int>.Min<int>(someList));
            Console.WriteLine(GenericList<int>.Max<int>(someList));
        }

        // first implemented funcionality
        #region Exercise 07 : Create generic methods Min<T>() and Max<T>() for finding the minimal and maximal element in the  GenericList<T>. You may need to add a generic constraints for the type T.
        // Min method for the current file not just a static method
        public static T Min<T>(GenericList<T> elements) where T : IComparable<T>
        {
            var result = elements[0];
            for (int i = 1; i < elements.Count; i++)
            {
                if (result.CompareTo(elements[i]) > 0)
                {
                    result = elements[i];
                }
            }
            return result;
        }

        // Max method for the current file not just a static method
        public static T Max<T>(GenericList<T> elements) where T : IComparable<T>
        {
            var result = elements[0];
            for (int i = 1; i < elements.Count; i++)
            {
                if (result.CompareTo(elements[i]) <= 0)
                {
                    result = elements[i];
                }
            }
            return result;
        }
        #endregion
    }
}
