using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsList : MonoBehaviour
{
    public string[] directorsPoints;
    //GameObject[] dP_GO_Array;
    public List<GameObject> dP_GO = new List<GameObject>();
    public GameObject stageGO;

    void Start()
    {
        stageGO = GameObject.Find("CentPoint(Clone)");
        if (stageGO != null)
        {
            Debug.Log("No stage found");
        }

        foreach (string str in directorsPoints)
        {
            Debug.Log("This is the current " + str + ".");
            GameObject g = GameObject.Find(str);
            dP_GO.Add(g);
        }       
    }



    //GameObject[] dP_GO;

    // void Points()
    //{
    //    foreach (string dP in directorsPoints)
    //    {
    //        dP = 
    //    } 
    //}
}
