using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Choices : MonoBehaviour
{
    GameObject director;
    
    // Start is called before the first frame update
    void Start()
    {
        director = GameObject.FindGameObjectWithTag("Director");
    }

    // Update is called once per frame
    void Update()
    {
               
    }

    private void OnTriggerStay(Collider other)
    {
        //if (other == other.gameObject.CompareTag("Player"))
        //{
        //    if(this.gameObject.name == "Choice1")
        //    {
                
        //        //Tell Director Choice 1
        //        Debug.Log("Choice 1");                
        //        //Updating = true
        //        director.gameObject.GetComponent<Director>().updating = true;
        //    }
        //    else if (this.gameObject.name == "Choice2")
        //    {
        //        //Tell Director Choice 2
        //        Debug.Log("Choice 2");
        //        //Updating = true
        //    }
        //}
    }
}
