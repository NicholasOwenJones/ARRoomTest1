//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Char1script : MonoBehaviour
//{
//    public GameObject TestingBox, centre;
//    public GameStart GameStart;
    
//    //public AudioClip testSound1;
//    //AudioSource audioSource;

//    void Start()
//    {
//        if (GameStart == null | centre == null)
//        {
//            centre = GameObject.FindGameObjectWithTag("centre");
//            GameStart = centre.GetComponent<GameStart>();
//        }
//        //    centre = GameObject.FindGameObjectWithTag("centre");
//        //    GameStart = centre.GetComponent<GameStart>();
//        //audioSource = GetComponent<AudioSource>();
//    }

//    void OnTriggerEnter(Collider other)
//    {
//        if (other.gameObject.tag == "Player")
//        {
//            //audioSource.PlayOneShot(testSound1, 10F);
//            //Instantiate(TestingBox, other.transform.position, other.transform.rotation);
//            GameStart.char1int = 1;

//        }
//    }
//}
