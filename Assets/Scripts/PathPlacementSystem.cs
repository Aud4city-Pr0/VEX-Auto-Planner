using UnityEngine;

public class PathPlacementSystem : MonoBehaviour
{
    // script vars
    public float distance = 1000f;
    public Camera cam;
    private bool canPlace = false;

    // Update is called once per frame
    void Update()
    {
        Ray mousePos = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(mousePos, out hit, distance)) {
            if(hit.collider.CompareTag("Placeable"))
            {
                canPlace = true; 
            } else
            {
                canPlace = false;
            }
            Debug.Log("place status: " + canPlace);
        } else
        {
            canPlace = false;
        }
    }
}
