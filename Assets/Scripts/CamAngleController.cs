using UnityEngine;

public class CamAngleController : MonoBehaviour
{
    // script vars
    public GameObject[] Angles;
    public int currentAngle = 0;
    

    // Update is called once per frame
    void Update()
    {
        if(currentAngle == 0)
        {
            GameObject angle = GetCurrentAngle(currentAngle);
            // setting cam position
            transform.position = angle.transform.position;
            transform.rotation = angle.transform.rotation;
        } else if(currentAngle == 1)
        {
            GameObject angle = GetCurrentAngle(currentAngle);
            // setting cam position
            transform.position = angle.transform.position;
            transform.rotation = angle.transform.rotation;
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
