using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getCoin : MonoBehaviour
{
    void OnTriggerStay(Collider col) {
       
        if (col.gameObject.tag == "coin") {
            Destroy(col.gameObject);
        }
    
    }
    
    // Start is called before the first frame update
   void Start()
    {
        
    }

    // Update is called once per frame
    //void Update()
    //{
        
    //}
}
