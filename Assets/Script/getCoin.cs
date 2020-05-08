using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class getCoin : MonoBehaviour
{
 
    void OnTriggerStay(Collider col) {
       
        if (col.gameObject.tag == "coin") {
            Destroy(col.gameObject);
            staticscore.score += 1;
        
         }
    
    }
    
    // Start is called before the first frame update
   void Start()
    {
       
    }
    
    //void Update() { 
       
    //}

    // Update is called once per frame
    //void Update()
    //{
        
    //}
}
