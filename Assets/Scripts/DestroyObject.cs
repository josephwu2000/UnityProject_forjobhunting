﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    public int sec = 3;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, sec);
    }
}
