﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move2 : MonoBehaviour
{
    public const int speed = 400;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, 0.05f * speed * Time.deltaTime);

        if (Input.GetKey("right"))
        {
            transform.Translate(0.1f, 0, 0);
        }
        if (Input.GetKey("left"))
        {
            transform.Translate(-0.1f, 0, 0);
        }
    }
}
