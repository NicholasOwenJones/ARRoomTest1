using System.Collections;
using System.Collections.Generic;
using GoogleARCore;
using GoogleARCore.Examples.Common;
using UnityEngine;
using UnityEngine.EventSystems;

public class GamesRules : MonoBehaviour
{
    public GameObject helloARContGO, centrePoint, location1, location2;
    public Vector3 centre;

    public bool location_2_ready;

    public bool gameStarts;


    // Start is called before the first frame update
    void Start()
    {
        location_2_ready = false;
        gameStarts = false;

        if (helloARContGO == null)
        {
            helloARContGO = GameObject.FindGameObjectWithTag("HelloARGO");
        }
    }


    void Update()
    {
        if (gameStarts == true)
        {
            gameStarts = false;
            CurtainUp();
        }

        if (location_2_ready == true)
        {
            CenterPoint();
        }

        
        /*if (helloARContGO.GetComponent<HelloARController>().Loc1() == true)
        {

        /}*/
    }

    public void PlaySpace()
    {
        if (location1 == null)
        {
            location1 = GameObject.FindGameObjectWithTag("Cube1");
            if (location2 == null)
            {
                location2 = GameObject.FindGameObjectWithTag("Cube2");
            }
            else
            {
                location_2_ready = true;
            }
        }
        else if (location2 == null)
        { 
            location2 = GameObject.FindGameObjectWithTag("Cube2");
        }
        else
        {
            location_2_ready = true;
        }
    }

    public void CenterPoint() //places a point in the middle of the play space.
    {
       if (GameObject.Find("centrePoint") != true)
       {
            Vector3 vec3 = (location1.transform.position + location2.transform.position) / 2;
            Instantiate(centrePoint, vec3, transform.rotation);
            //centrePoint.transform.position = (location1.transform.position + location2.transform.position) / 2;
            location_2_ready = false;
            gameStarts = true;
            centrePoint = null;
       }
        /*if (GameObject.Find("centrePoint") != null)
        {
            gameStarts = true;
        }*/
    }

    public void CurtainUp()
    {
        //this is where the character objects come in and stuff...
    }

}
