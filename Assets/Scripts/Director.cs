using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Director : MonoBehaviour
{
    /// <summary>
    ///  Variables
    /// </summary>

    #region
    [Header("NOW DO! Use this to input Ints to jump between parts of the story.")]
    // Current int for tracking everything.
    public IntReference nowDo;
    public IntVariable nowDoSetter; //used for setting and changing the int so other objects can use it to check what they should be doing - if needed.

    [Header("Updating - must return true to move the characters position.")]
    // A bool to stop things updating over and over - linked to UpdateIt for Char1 and 2.
    public bool updating;

    //GameObjects for Characters, GO for any other items in the scene (birds, fire, etc.)

    [Header("Character 1")]
    //Character1(char1) movement list
    public GameObject char1; //GameObjects for Character
    public string[] char1move; //list of points to move to: 000
    public StringVariable char1CurrentPoint; //the location to move to
    public FloatVariable char1MoveSpeed; //for setting the speed the character should move to the next point.
    public BoolReference updateIt_Char1; //tells updateit when the char has done it's thing

    [Header("Character 2")]
    //Character2(char2) movement list
    public GameObject char2; //GameObjects for Character
    public string[] char2move; //list of points to move to: 000
    public StringVariable char2CurrentPoint; //the location to move to
    public FloatVariable char2MoveSpeed; //for setting the speed the character should move to the next point.
    public BoolReference updateIt_Char2; //tells updateit when the char has done it's thing

    [Header("Stage Size")]
    //The diagonal distance between the two stage points placed by the player. 
    public FloatReference stageDistance; //Get this from StretchOut script.
    public FloatVariable pointRadius; //the size of each point to move to (StageDistance/20?)
    #endregion

    [Header("Choices")]
    public GameObject choices;

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

        pointRadius.Value = stageDistance.Value / 40; //Sets the area around each point that the characters should move to.
    }

    // Update is called once per frame
    void Update()
    {
        //Checks if the two characters have finished what they need to do before continuing.
        //Debug.Log("Updating " + updating + ", Char1: " + updateIt_Char1.Value + ", Char2: " + updateIt_Char2.Value + "...... Moving to:" + char1CurrentPoint.Value);
        if (updateIt_Char1 == true && updateIt_Char2 == true)
        {
            updating = true;
            //Debug.LogWarning("Updating " + updating + ", updateIt_Char1 " + updateIt_Char1.Value + ", updateIt_Char2 " + updateIt_Char2.Value);
        }

        if (updating == true) //sets whats happening in the story.
        {
            //nowDo.Value won't update unless another script sets it to a new number. This should be done by the player choice 

            if (nowDo.Value == 0)
            {
                updating = false;             
                //Debug.Log("updating part 0");
                Invoke("Part0", 0.1f);
            }
            else if (nowDo.Value == 1)
            {
                updating = false;
                //Debug.Log("updating part 1");
                Invoke("Part1", 0.1f);
            }
            else if (nowDo.Value == 2)
            {
                updating = false;
                //Debug.Log("updating part 2");
                Invoke("Part2", 0.1f);
            }
            else if (nowDo.Value == 3)
            {
                updating = false;
                //Debug.Log("updating part 2");
                Invoke("Part3", 0.1f);
            }
        }
        //if current int == int then do nothing.
        //If int = part1() set current int to int.
        //elseif int = part2() set current int to int.
        //etc.

        //If the int updates then characters positions and sounds should update too.
    }

    /// <summary>
    ///  PARTS - location of each character and code for what needs to go in there.
    /// </summary>
    #region
    void Part0()
    {
        GameObject choice1 = GameObject.Find("point605");
        Instantiate(choices, choice1.transform);
        //Debug.Log("This is part 0");
        char1CurrentPoint.Value = char1move[0];
        char2CurrentPoint.Value = char2move[0];
        //position the character here with this audio.
        nowDoSetter.Value = 1;
    }

    void Part1()
    {
        //Debug.Log("This is part 1");
        char1CurrentPoint.Value = char1move[1];
        char2CurrentPoint.Value = char2move[1];
        nowDoSetter.Value = 2;
        //position the character here with this audio.
    }

    void Part2()
    {
        //Debug.Log("This is part 2");
        char1CurrentPoint.Value = char1move[2];
        char2CurrentPoint.Value = char2move[2];
        nowDoSetter.Value = 3;
        //position the character here with this audio.
    }

    void Part3()
    {
        //Debug.Log("This is part 3");
        char1CurrentPoint.Value = char1move[3];
        char2CurrentPoint.Value = char2move[3];
        nowDoSetter.Value = 0;
        //position the character here with this audio.
    }
}
#endregion
