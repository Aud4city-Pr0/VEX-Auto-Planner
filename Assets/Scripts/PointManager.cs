using UnityEngine;
using System;
public class PointManager : MonoBehavior
{
    public static List<Point> points = new List<Point> {};

    public static void AddPoint(double x, double y)
    {
        points.Add(new Point(x, y));
    }

    public static void ChangePoint(int pointIndex, double x, double y)
    {
        points[pointIndex].X_Coord.set(x);
        points[pointIndex].Y_Coord.set(y);
    }

    public static void DeletePoint(int pointIndex)
    {
        points.RemoveAt(pointIndex);
    }
}