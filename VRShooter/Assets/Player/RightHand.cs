using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightHand : PlayerController {

    
    public static RightHand instance;

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
