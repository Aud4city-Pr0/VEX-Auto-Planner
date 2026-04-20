using UnityEngine;
using System.Collections.Generic;
using Unity.Mathematics;
public class PointManager : MonoBehaviour
{
    public static List<Point> points = new List<Point> {};

    public static void AddPoint(float x, float y)
    {
        points.Add(new Point((double)x, (double)y));
        Debug.Log("Added new point at");
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

    public static void PointsToCode() {
        for (int i = 0; i < points.Count - 1; i++) {
            Debug.Log($"chassis.pid_turn_set({Point.GetAngle(points[i], points[i+1])}_deg, 100);");
            Debug.Log("chassis.pid_wait_quick_chain();");
            Debug.Log($"chassis.pid_drive_set({Point.GetDist(points[i], points[i+1])}_in, 100);");
            Debug.Log("chassis.pid_wait();");
        }
    }
}