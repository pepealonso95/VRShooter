using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserBullet : MonoBehaviour {
    public int damage = 500;
    public int multiplier = 1;

    private void Start()
    {
        Destroy(gameObject, 222f);
    }

    public int GetDamage()
    {
        return damage * multiplier;
    }
}
