using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

public class GenericList<T>
{
    // default fixed size
    private int DefaultCapacity = 1000;

    private T[] elements;
    private int count = 0;

    public GenericList()
    {
        // initialize array with default size
        elements = new T[DefaultCapacity];
    }

    public int Count
    {
        get
        {
            return this.count;
        }
    }

    #region Exercise 05 : Implemented Methods
    // for adding element
    public void Add(T element)
    {
        if (count >= elements.Length)
        {
            AutoGrow();
        }
        this.elements[count] = element;
        count++;
    }

    // accessing element by index
    public T this[int index]
    {
        get
        {
            if (index >= count)
            {
                throw new IndexOutOfRangeException(String.Format(
                    "Invalid index: {0}.", index));
            }
            T result = elements[index];
            return result;
        }
    }

    // removing element by index
    public void RemoveByIndex(int index)
    {
        List<T> newElements = elements.ToList();
        newElements.RemoveAt(index);
        count--;
        elements = newElements.ToArray();
    }

    // inserting element at given position
    public void InsertAtPosition(int index, T element) 
    {
        List<T> newElements = elements.ToList();
        newElements.Insert(index, element);
        count++;
        if (count >= DefaultCapacity)
        {
            AutoGrow();
        }
        elements = newElements.ToArray();
    }

    // clearing the list
    public void Clear() 
    {
        elements = new T[DefaultCapacity];
    }

    // finding element by its value and returning index in list
    public int IndexOf(T element) 
    {
        int result = Array.IndexOf(elements, element);
        return result;
    }

    // overriding ToString() method to return string joined by "," as result
    public override string ToString()
    {
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < count; i++)
        {
            result.AppendFormat("{0},", elements[i]);
        }
        return result.ToString();
    }
    #endregion

    // Exercise 06 : auto-grow functionality
    private void AutoGrow()
    {
        this.DefaultCapacity *= 2;
        T[] newElements = new T[DefaultCapacity];
        Array.Copy(elements, newElements, elements.Length);
        elements = newElements.ToArray();
    }

    // second implemented functionality
    #region Exercise 07 : Create generic methods Min<T>() and Max<T>() for finding the minimal and maximal element in the  GenericList<T>. You may need to add a generic constraints for the type T.
    // Min method as static to the current class
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

    // Max method as static to the current class
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
