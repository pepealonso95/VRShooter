using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserGun : MonoBehaviour,FireArm {

    public GameObject laser;
    public Transform barrelEnd;
    public int pulse = 500;
    public int damageMultiplier = 1;
    public float fireSpeed = 5000f;
    public int rounds = 10;

    public void Fire()
    {
        if (rounds > 0)
        {
            GameObject laserInstance = Instantiate(laser, barrelEnd.position, barrelEnd.rotation);
            laserInstance.GetComponent<LaserBullet>().multiplier = damageMultiplier;
            laserInstance.GetComponent<Rigidbody>().AddForce(barrelEnd.forward * fireSpeed);
            rounds--;
            print("fire");
        }
    }

    public void Reload(int ammo)
    {
        throw new System.NotImplementedException();
    }

    public ushort PulseDuration()
    {
        return (ushort)pulse;
    }
}
