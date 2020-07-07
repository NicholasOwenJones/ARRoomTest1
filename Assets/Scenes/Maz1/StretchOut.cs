using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StretchOut : MonoBehaviour {

    public GameObject firstPoint, secondPoint, centerPoint, centCube;

    public FloatVariable floatLengthZ, floatLengthX, stageDistance;

    public float lengthZ, lengthX;

    // Use this for initialization
    void Start () {
        firstPoint = GameObject.Find("Cube1");
        secondPoint = GameObject.Find("Cube2");
        Vector3 vec3 = (firstPoint.transform.position + secondPoint.transform.position) / 2;
        //var gameObt = Instantiate(centerPoint, vec3, transform.rotation);
        Instantiate(centerPoint, vec3, transform.rotation);

        //distance between the first and second points on z and x.
        lengthZ = Mathf.Abs(firstPoint.transform.position.z - secondPoint.transform.position.z);
        lengthX = Mathf.Abs(firstPoint.transform.position.x - secondPoint.transform.position.x);

        centCube = GameObject.FindWithTag("centre");
        centCube.transform.localScale = new Vector3(lengthX, 0.1f, lengthZ);

        floatLengthX.Value = lengthX;
        floatLengthZ.Value = lengthZ;

        stageDistance.Value = lengthX + lengthZ / 2;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
