using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserBullet : MonoBehaviour {
    public int damage = 500;
    public int multiplier = 1;
    public float lifeSpan = 250f;
    public GameObject bulletMark;

    private void Start()
    {
        Destroy(gameObject, lifeSpan);
    }

    public int GetDamage()
    {
        return damage * multiplier;
    }
}
