using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZEffects;

public class LaserGun : MonoBehaviour,FireArm {

    public EffectTracer tracerEffect;
    public Transform muzzleTransform;
    public int pulse = 500;

    public void Fire()
    {
        RaycastHit hit = new RaycastHit();
        Ray ray = new Ray(muzzleTransform.position, muzzleTransform.forward);

        tracerEffect.ShowTracerEffect(muzzleTransform.position, muzzleTransform.forward, 250f);
    }

    public void Reload(int ammo)
    {
        throw new System.NotImplementedException();
    }
    

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public ushort PulseDuration()
    {
        return (ushort)pulse;
    }
}
