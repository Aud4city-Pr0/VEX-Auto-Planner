using UnityEngine;
using UnityEngine.InputSystem;

public class PathPlacementSystem : MonoBehaviour
{
    // script vars
    public float distance = 1000f;
    public Camera cam;
    private bool canPlace = false;
    public GameObject pointPrefab;
    public GameObject phantomPrefab;

    float rotationY = 0f;
    GameObject phantomInstance;

    InputAction generateAction;

    InputAction rotateAction;

    void Start()
    {

        phantomInstance = Instantiate(phantomPrefab);
        generateAction = InputSystem.actions.FindAction("Generate");
        rotateAction = InputSystem.actions.FindAction("Rotate");
    }

    // Update is called once per frame
    void Update()
    {
        Ray mousePos = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(mousePos, out hit, distance)) {
            phantomInstance.transform.position = hit.point;

            if(rotateAction.IsPressed())
            {
                rotationY += 90;
            }

            if(hit.collider.CompareTag("Placeable"))
            {
                canPlace = true; 
            } else
            {
                canPlace = false;
            }
            //Debug.Log("place status: " + canPlace);
            phantomInstance.transform.Rotate(new Vector3(0, rotationY, 0));

            // mouse button code
            if(Mouse.current.leftButton.wasPressedThisFrame && canPlace == true)
            {
                GameObject placedPoint = Instantiate(pointPrefab, hit.point, Quaternion.identity);
                PointManager.AddPoint(placedPoint.transform.position.x * 39.3701f, placedPoint.transform.position.y * 39.3701f);
            }
        } else
        {
            canPlace = false;
        }

        if(generateAction.IsPressed())
        {
            PointManager.PointsToCode();
        }

        
    }
}
