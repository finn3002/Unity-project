using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endmove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("down") || Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -5 * Time.deltaTime);
        }

        if (Input.GetKey("up") || Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, 5 * Time.deltaTime);
        }

        if (Input.GetKey("left") || Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, 180 * Time.deltaTime, 0);
        }

        if (Input.GetKey("right") || Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, -180 * Time.deltaTime, 0);
        }
    }
}
