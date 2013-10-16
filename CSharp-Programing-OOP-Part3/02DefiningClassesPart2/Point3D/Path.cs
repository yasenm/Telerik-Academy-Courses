using System;
using System.Collections.Generic;

public class Path<T>
{
    public List<T> PathOfPoints = new List<T>();

    public void AddPoint(T point) 
    {
        this.PathOfPoints.Add(point);
    }

    public void ClearPath() 
    {
        this.PathOfPoints.Clear();
    }
}
