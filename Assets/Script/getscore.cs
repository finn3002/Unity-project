using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getscore : MonoBehaviour {

    public Text Showscore;
 


    // Start is called before the first frame update
    void Start()
    {
    //staticscore.score=0;
    }

    // Update is called once per frame
    void Update()
    {
        Showscore.text = "x "+staticscore.score.ToString();
    }
}
