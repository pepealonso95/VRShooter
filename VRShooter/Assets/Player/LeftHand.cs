using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftHand : MonoBehaviour {

    public GameObject heldWeapon;
    public SteamVR_TrackedObject trackedObject;

    public static LeftHand instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    private void OnDestroy()
    {
        if (instance == this)
        {
            instance = null;
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        var device = SteamVR_Controller.Input((int)trackedObject.index);
        FireArm arm = heldWeapon.GetComponent<FireArm>();
        if (heldWeapon!=null&& device.GetPressDown(SteamVR_Controller.ButtonMask.Trigger))
        {
            arm.Fire();
            device.TriggerHapticPulse(arm.PulseDuration());
        }

	}
}
