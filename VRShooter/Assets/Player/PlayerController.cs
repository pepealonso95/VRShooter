using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{


    public GameObject heldWeapon;
    public SteamVR_TrackedObject trackedObject;
    protected FixedJoint joint;
    protected Rigidbody body;

    // Use this for initialization
    void Start()
    {
    }

    void OnTriggerEnter(Collider other)
    {
        if (heldWeapon != null || !other.gameObject.CompareTag("Weapon"))
        {
            return;
        }

        heldWeapon = other.gameObject;
    }

    /*
     void OnTriggerExit(Collider other)
    {
        if (heldWeapon!=null&&other.gameObject.CompareTag("Weapon")&&other.gameObject.Equals(heldWeapon))
        {
            heldWeapon = null;
        }
    }*/

    // Update is called once per frame
    void Update()
    {
        var device = SteamVR_Controller.Input((int)trackedObject.index);
        if (body != null && heldWeapon != null && device.GetPressDown(SteamVR_Controller.ButtonMask.Trigger))
        {
            FireArm arm = heldWeapon.GetComponent<FireArm>();
            arm.Fire();
            device.TriggerHapticPulse(arm.PulseDuration());
        }
        else if (body == null && heldWeapon != null && device.GetPressDown(SteamVR_Controller.ButtonMask.Grip))
        {
            body = heldWeapon.GetComponent<Rigidbody>();
            body.transform.position = transform.position;
            body.useGravity = false;
            joint.connectedBody = body;

        }
        else if (body != null && heldWeapon != null && device.GetPressUp(SteamVR_Controller.ButtonMask.Grip))
        {
            body.velocity = device.velocity;
            body.angularVelocity = device.angularVelocity;
            body.useGravity = true;
            body = null;
            joint.connectedBody = null;
            heldWeapon = null;

        }
    }
}
