using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WandController : MonoBehaviour
{
    private Valve.VR.EVRButtonId gridButton = Valve.VR.EVRButtonId.k_EButton_Grip;
    private Valve.VR.EVRButtonId triggerButton = Valve.VR.EVRButtonId.k_EButton_SteamVR_Trigger;

    public bool gridButtonDown = false;
    public bool gridButtonUp = false;
    public bool gridButtonPressed = false;

    public bool triggerButtonDown = false;
    public bool triggerButtonUp = false;
    public bool triggerButtonPressed = false;

    private SteamVR_Controller.Device controller
    {
        get
        {
            return SteamVR_Controller.Input((int)trackedObj.index);
        }
    }
    private SteamVR_TrackedObject trackedObj;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (controller == null)
        {
            Debug.Log("Controller not initialized");
        }

        gridButtonDown = controller.GetPressDown(gridButton);
        gridButtonUp = controller.GetPressUp(gridButton);
        gridButtonPressed = controller.GetPress(gridButton);

        triggerButtonDown = controller.GetPressDown(triggerButton);
        triggerButtonUp = controller.GetPressUp(triggerButton);
        triggerButtonPressed = controller.GetPress(triggerButton);

        if (gridButtonDown)
        {
            Debug.Log("Grip button was just pressed");
        }
        if (gridButtonUp)
        {
            Debug.Log("Grip button was just unpressed");
        }
        if (triggerButtonDown)
        {
            Debug.Log("Trigger button was just pressed");
        }
        if (triggerButtonUp)
        {
            Debug.Log("Trigger button was just unpressed");
        }
    }

    private void Awake()
    {
        trackedObj = GetComponent<SteamVR_TrackedObject>();
    }
}
