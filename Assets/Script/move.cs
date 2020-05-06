using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class move : MonoBehaviour
{
    public const int speed = 200;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {       
        transform.Translate(0, 0, 0.05f * speed *  Time.deltaTime);

        if (Input.GetKey("right"))
        {
            transform.Translate(0.1f, 0, 0);
        }
        if (Input.GetKey("left"))
        {
            transform.Translate(-0.1f, 0, 0);
        }
        
        
    }
    void onCollisionEnter(Collision col) {
        
    }
    
}
