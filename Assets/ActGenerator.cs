using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActGenerator : MonoBehaviour
{
    public float point_radius = 0.1f;
    public float moveSpeed = 2;
    public GameObject[] points;

    public GameObject startPoint;
    public GameObject character1block;
    GameObject character1;

    public int current = 0;



    // Start is called before the first frame update
    void Start()
    {
        startPoint = GameObject.Find("point-900");
        Instantiate(character1block);
        character1 = GameObject.FindGameObjectWithTag("Char1");
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(points[current].transform.position, character1.transform.position) < point_radius)
        {
            current++;
            if(current >= points.Length)
            {
                current = 0;
            }
        }
        character1.transform.position = Vector3.MoveTowards(character1.transform.position, points[current].transform.position, Time.deltaTime * moveSpeed);
    }
}
