using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftHand : PlayerController {
    
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
}
