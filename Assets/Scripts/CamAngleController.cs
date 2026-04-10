using UnityEngine;

public class CamAngleController : MonoBehaviour
{
    // script vars
    public GameObject[] Angles;
    public int currentAngle = 0;
    

    // Update is called once per frame
    void Update()
    {
        GameObject Angle = GetCurrentAngle(currentAngle);
        if(Angle != null)
        {
          transform.position = Angle.transform.position;
          transform.rotation = Angle.transform.rotation; 
        }
    }


    // camera setting angle code
    private GameObject GetCurrentAngle(int index)
    {
        if (index >= 0 && index < Angles.Length)
        {
            return Angles[index];
        }
        return null;
    }
}
