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

    void Start()
    {

        phantomInstance = Instantiate(phantomPrefab);
        generateAction = InputSystem.actions.FindAction("Generate");
    }

    // Update is called once per frame
    void Update()
    {
        Ray mousePos = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(mousePos, out hit, distance)) {
            phantomInstance.transform.position = hit.point;
            if(hit.collider.CompareTag("Placeable"))
            {
                canPlace = true; 
            } else
            {
                canPlace = false;
            }
            //Debug.Log("place status: " + canPlace);

            // mouse button code
            if(Mouse.current.leftButton.wasPressedThisFrame && canPlace == true)
            {
                Instantiate(pointPrefab, hit.point, Quaternion.identity);
                PointManager.AddPoint(hit.point.x, hit.point.y);
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
