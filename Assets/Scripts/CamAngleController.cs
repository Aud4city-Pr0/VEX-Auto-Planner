using UnityEngine;

public class CamAngleController : MonoBehaviour
{
    // script vars
    public GameObject[] Angles;
    public int currentAngle = 0;
    public bool isThirdPerson = false;
    public float speed = 3.5f;

    private float yaw = 0f;
    private float pitch = 0f;
    

    // Update is called once per frame
    void Update()
    {
        GameObject Angle = GetCurrentAngle(currentAngle);
        // Set base position
        transform.position = Angle.transform.position;

        // Start from base rotation
        Quaternion baseRotation = Angle.transform.rotation;

        // Apply mouse rotation if in third person
        if (Input.GetMouseButton(0) && isThirdPerson)
        {
            float rotationX = Input.GetAxis("Mouse X") * speed;
            float rotationY = Input.GetAxis("Mouse Y") * speed;

            // Accumulate rotation
            yaw += rotationX;
            pitch -= rotationY;

            // Optional clamp (prevents flipping)
            pitch = Mathf.Clamp(pitch, -80f, 80f);
        }

        // Combine base + offset rotation
        Quaternion offsetRotation = Quaternion.Euler(pitch, yaw, 0);
        transform.rotation = baseRotation * offsetRotation;
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
