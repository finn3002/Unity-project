using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scorezero : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        staticscore.score = 0;
        staticbar.current = staticbar.max;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
