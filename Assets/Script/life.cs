using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class life : MonoBehaviour
{
    public string goToTheScene;
    void OnTriggerEnter(Collider other)
    {
       

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if (staticbar.current <= 0) 
        {
            SceneManager.LoadScene(goToTheScene);
        }
    }
}
