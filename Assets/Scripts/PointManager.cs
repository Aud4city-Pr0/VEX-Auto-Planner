using UnityEngine;
using System.Collections.Generic;
public class PointManager : MonoBehaviour
{
    public static List<Point> points = new List<Point> {};

    public static void AddPoint(double x, double y)
    {
        points.Add(new Point(x, y));
        Debug.Log($"Added new point at: {x, y}");
    }

    public static void ChangePoint(int pointIndex, double x, double y)
    {
        points[pointIndex].X_Coord.set(x);
        points[pointIndex].Y_Coord.set(y);
        Debug.Log($"changed point at: i: {pointIndex} p: {x, y}");
    }

    public static void DeletePoint(int pointIndex)
    {
        points.RemoveAt(pointIndex);
        Debug.Log($"removed point at: i: {pointIndex}");
    }
}