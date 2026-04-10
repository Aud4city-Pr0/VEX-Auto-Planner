using UnityEngine;
using UnityEngine.UI;

public class CamButtonScript : MonoBehaviour
{
    // script vars
    public Camera cam; 
    public Button btn;
    private int camToggle = 1;
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
        if(camToggle == 1)
        {
            camController.isThirdPerson = false;
            camController.currentAngle = 1;
            camToggle = 2;
        } else if(camToggle == 2)
        {
            camController.currentAngle = 0;
            camToggle = 3;
        } else if(camToggle == 3)
        {
            camController.currentAngle = 2;
            camController.isThirdPerson = true;
            camToggle = 1;
        }
    }
}
