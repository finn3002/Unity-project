using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class unlimit : MonoBehaviour
{
    public Collider bound;
    //public GameObject bound; //物件的生成點。
    public GameObject gameObject1; //要生成的物件。
    void onCollisionEnter(Collision col) {
        if (col.gameObject.tag == "Player") {
            Destroy(col.gameObject);
            Copy();
        }
    }
    void Copy() {
        float length = bound.bounds.extents.z * 2;
        Instantiate(gameObject1, transform.position + new Vector3(-78,0,0), transform.rotation);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
