using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthBar : MonoBehaviour
{
    public int jumpCount = 1;//空白鍵跳躍
    public  Image Lifepoint;//血條
   // public const float max = 100;
    //public float current = max;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "car")
        {
            staticbar.current -= 20;
            Lifepoint.fillAmount = (staticbar.current / 100);
            //Destroy(col.gameObject);
            //current = current - 10;
           // HealthBar.UpdateBar(current, max);.
        }
        else if (col.gameObject.tag == "floor") {//撞地板才能再跳
            jumpCount = 1;
        }
    }
    // Start is called before the first frame update
   void Start()
    {
        //  Image Lifepoint = GetComponent<Image>();//呼叫圖片(?
        Lifepoint.fillAmount = (staticbar.current / 100);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && jumpCount == 1)//如果我在地板且按空白鍵則可以跳
        {
            GetComponent<Rigidbody>().AddForce(0, 250, 0);
            jumpCount = 0;//現在在空中
        }
    }
}
