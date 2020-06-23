using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DumbEnemy : MonoBehaviour
{

    //public FloatVariable FloatsVar;
    //public FloatReference MaxHP;
    //public FloatReference MoveSpeed;


    public GameObject aGameObj; //empty GameObject filled by the array.
    public string[] pointsToLocate; //the array of point names to locate, needs to be filled in accurately to avoid missed locations and errors.

    public StringReference objectName;
    public StringVariable namer; 
    
    private int currentPoint = 0; //used to track which point is being looked for in the array.

    private void Update()
    {
        //Debug.LogWarning("My name is " + DumbName.Value + ".");
        //Debug.Log("MaxHP is " + FloatsVar.Value + ".");
        //Debug.Log("MaxHP is " + MaxHP.Value + ".");
        //Debug.Log("MoveSpeed is " + MoveSpeed.Value + ".");


        //finds a GameObject with the same name as a string on the list. 
        namer.Value = pointsToLocate[currentPoint]; //*THIS CAN BE DONE FROM A SEPERATE SCRIPT OR GAMEOBJECT* Tells the StringVariable to change to the name on the array. The StringVariable sets the StringReference "objectName" to the same value.
        aGameObj = GameObject.Find(objectName.Value); //This finds a GameObject in the scene with the same name as the current sting name in the list using the above StringReference "objectName".
        Debug.LogWarning("The GameObject is " + aGameObj.name + " before any changes. <<<<");
        if (aGameObj != null)
        {
            Debug.LogWarning("The GameObject is " + aGameObj.name + " after change.");

            currentPoint++; //increases currentPoints by one after the below has run. This could be an IntReference that increases from other locations when tasks are completed by the player. Telling objects to move as needed.
            if (currentPoint >= pointsToLocate.Length) //checks to make sure the current point isnt beyond the range of locations.
            {
                currentPoint = 0;
            }
        }
    }
}
