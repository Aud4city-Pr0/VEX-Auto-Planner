using UnityEngine;
using UnityEngine.UI;

public class CamButtonScript : MonoBehaviour
{
    // script vars
    public Camera cam; 
    public Button btn;
    private bool camToggle = false;
    private CamAngleController camController;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // button code setup
        camController = cam.GetComponent<CamAngleController>();
        btn.onClick.AddListener(OnCamButtonClicked);
    }

    public void OnCamButtonClicked()
    {
        // making sure function is fired correctly
        Debug.Log("Clicked");
        if(camToggle == false)
        {
            camController.currentAngle = 1;
            camToggle = true;
        } else if(camToggle == true)
        {
            camController.currentAngle = 0;
            camToggle = false;
        }
    }
}
