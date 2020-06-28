using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Director : MonoBehaviour
{
    // Current int for tracking everything.
    public IntReference nowDo;
    public IntVariable nowDoSetter; //used for setting and changing the int so other objects can use it to check what they should be doing - if needed.


    // A bool to stop things updating over and over
    public bool updating;

    //GameObjects for Characters x2, GO for any other items in the scene (birds, fire, etc.)
    public GameObject char1, char2;

    //Character1(char1) movement list
    public string[] char1move; //list of points to move to: 000
    public FloatVariable char1MoveSpeed; //for setting the speed the character should move to the next point.

    //Character2(char2) movement list
    public string[] char2move; //list of points to move to: 000
    public FloatVariable char2MoveSpeed; //for setting the speed the character should move to the next point.

    //The diagonal distance between the two stage points placed by the player. 
    public FloatReference stageDistance; //Get this from StretchOut script.

    // Start is called before the first frame update
    void Start()
    {
        updating = true;
        //establish the characters and code if needed.

        if (char1 == null)
        {
            char1 = GameObject.FindGameObjectWithTag("Char1");
        }

        if (char2 == null)
        {
            char2 = GameObject.FindGameObjectWithTag("Char1");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (updating) //sets whats happening in the story.
        {
            if (nowDo.Value == 1)
            {
                updating = false;
                Part1();
            }
            else if (nowDo.Value == 2)
            {
                updating = false;
                Part2();
            }
            else if (nowDo.Value == 3)
            {
                updating = false;
                Part3();
            }
        }
        //if current int == int then do nothing.
        //If int = part1() set current int to int.
        //elseif int = part2() set current int to int.
        //etc.

        //If the int updates then characters positions and sounds should update too.
    }

    void Part1()
    {
        //position the character here with this audio.
    }

    void Part2()
    {
        //position the character here with this audio.
    }

    void Part3()
    {
        //position the character here with this audio.
    }
}
