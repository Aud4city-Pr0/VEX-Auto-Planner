using UnityEngine;
using System.Collections.Generic;
using Unity.Mathematics;
public class PointManager : MonoBehaviour
{
    public static List<Point> points = new List<Point> {};

    public static void AddPoint(float x, float y)
    {
        points.Add(new Point((double)x, (double)y));
        Debug.Log("Added new point");
    }

    public static void ChangePoint(int pointIndex, double x, double y)
    {
        points[pointIndex].X_Coord = y;
        points[pointIndex].Y_Coord = x;
    }

    public static void DeletePoint(int pointIndex)
    {
        points.RemoveAt(pointIndex);
        Debug.Log($"removed point at: i: {pointIndex}");
    }
}