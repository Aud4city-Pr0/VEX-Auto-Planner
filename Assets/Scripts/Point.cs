using UnityEngine;
public class Point : MonoBehaviour
{
    private double x_coord;
    private double y_coord;

    public double X_Coord
    {
        get { return x_coord; }
        set { x_coord = value; }
    }

    public double Y_Coord
    {
        get { return y_coord; }
        set { y_coord = value; }
    }

    public Point(double x, double y)
    {
        x_coord = x;
        y_coord = y;
    }

    public static double GetDist(Point a, Point b)
    {
        return Mathf.Sqrt( Mathf.Pow( a.x_coord - b.x_coord, 2 ) + Mathf.Pow( a.y_coord - b.y_coord, 2 ) );
    }

    public static double GetAngle(Point a, Point b)
    {
        double x_dif = Mathf.Abs( a.x_coord - b.x_coord );
        double y_dif = Mathf.Abs( a.y_coord - b.y_coord );
        double angle = Mathf.Atan( y_dif / x_dif ); // angle in radians
        return angle*180/Mathf.PI; // converts to degrees
    }
}
