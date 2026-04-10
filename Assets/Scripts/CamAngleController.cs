using UnityEngine;

public class CamAngleController : MonoBehaviour
{
    // script vars
    public GameObject[] Angles;
    public int currentAngle = 0;
    public bool isThirdPerson = false;
    public float speed = 3.5f;
    

    // Update is called once per frame
    void Update()
    {
        GameObject Angle = GetCurrentAngle(currentAngle);
        if(Angle != null)
        {
          transform.position = Angle.transform.position;
          transform.rotation = Angle.transform.rotation; 
        }

        if (Input.GetMouseButton(0) && isThirdPerson == true) { // Checks to see if button is pressed and thrid person mode is enabled
            float rotationX = Input.GetAxis("Mouse X") * speed;
            float rotationY = Input.GetAxis("Mouse Y") * speed;
            transform.Rotate(new Vector3(-rotationY, rotationX, 0));
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
