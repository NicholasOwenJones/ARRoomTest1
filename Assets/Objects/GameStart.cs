//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class GameStart : MonoBehaviour
//{

//    public GameObject Character1, Character2, Character3, TestBox;

//    public float diagonalLenth; 

//    // Objects that are found in scene.

//    public GameObject player, cube1, cube2, centre;

//    //public Vector3 cube1Vec3, cube2Vec3, centreVec3;
//    //public Transform cube1transf , cube2transf, cent_transf;

//    public Vector3 cube1transf, cube2transf, cent_transf;

//    public Quaternion zero;

//    public int char1int, char2int, char3int;

//    //Audio

//    public AudioClip char1Sounds;
//    AudioSource audioSource;

//    // Start is called before the first frame update
//    void Start()
//    {
//        //Audio
//        audioSource = GetComponent<AudioSource>();
        
//        //Gets GameObjects
//        player = GameObject.FindGameObjectWithTag("Player");
//        centre = GameObject.FindGameObjectWithTag("centre");
//        cube1 = GameObject.FindGameObjectWithTag("Cube2");
//        cube2 = GameObject.FindGameObjectWithTag("Cube1");

//        //Float
//        diagonalLenth = Vector3.Distance(cube1.transform.position, cube2.transform.position);

//        //The positions of the objects (there might be a better way to do this?)
//        //currently messing around with the positions.
//        cube1transf = new Vector3(cube1.transform.position.x*(diagonalLenth/2), cube1.transform.position.y, cube1.transform.position.z*(diagonalLenth/2));
//        cube2transf = new Vector3(cube2.transform.position.x*(diagonalLenth/2), cube2.transform.position.y, cube2.transform.position.z*(diagonalLenth/2));
//        cent_transf = new Vector3(centre.transform.position.x, centre.transform.position.y, centre.transform.position.z);

//        //puts the chatacters 
//        Instantiate(Character1, cent_transf, transform.rotation);
//        Instantiate(Character2, cube2transf, transform.rotation);
//        Instantiate(Character3, cube1transf, transform.rotation);

//        //The code below will set the characters to spawn at the cube locations with the scale related to the ubes.
//        //cube1transf = cube1.transform;
//        //cube2transf = cube2.transform;
//        //cent_transf = centre.transform;

//        //Instantiate(Character1, cent_transf);
//        //Instantiate(Character1, cube1transf);
//        //Instantiate(Character2, cube2transf);

//        //not sure if the below works, should rescale the characters, but doesn't seem to.
//        //Character3.transform.localScale = new Vector3(1, 2f, 1);
//        //Character1.transform.localScale = new Vector3(1, 2f, 1);
//        //Character2.transform.localScale = new Vector3(1, 2f, 1);

//        //Ints to check how far in the story each character is.
//        //Plan to add/remove one or multiples to move to new points in the story line.
//        //probably a better way to do this.
//        char1int = 0;
//        char2int = 0;
//        char3int = 0;
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        if (char1int > 0)
//        {
//            Instantiate(TestBox, cent_transf, transform.rotation);
//            //audioSource.PlayOneShot(char1Sounds, 10F);
//        }
//    }

//    //
//    void Char1()
//    {
        
//    }

//    void Char2()
//    {

//    }

//    void Char3()
//    {

//    }
//}
