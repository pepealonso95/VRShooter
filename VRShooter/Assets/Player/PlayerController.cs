using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{


    public GameObject heldWeapon;
    public SteamVR_TrackedObject trackedObject;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        var device = SteamVR_Controller.Input((int)trackedObject.index);
        if (heldWeapon != null && device.GetPressDown(SteamVR_Controller.ButtonMask.Trigger))
        {
            FireArm arm = heldWeapon.GetComponent<FireArm>();
            arm.Fire();
            device.TriggerHapticPulse(arm.PulseDuration());
        }
    }
}
