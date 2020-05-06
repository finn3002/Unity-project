using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthBarNoJump : MonoBehaviour
{
    public Image Lifepoint;//血條
    //public SimpleHealthBar HealthBar;
    public const float max = 100;
    public float current = max;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "car")
        {
            current -= 10;
            Lifepoint.fillAmount = (current / 100);
            //Destroy(col.gameObject);
            //current = current - 10;
            //HealthBar.UpdateBar(current, max);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        Image Lifepoint = GetComponent<Image>();//呼叫圖片(?
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
