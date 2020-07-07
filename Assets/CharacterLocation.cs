using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterLocation : MonoBehaviour
{
    public StringReference point; // the current point name to move to.

    public GameObject pointToMoveTo; // leave empty.

    public FloatReference point_radius, moveSpeed; // distance to each point.

    // Start is called before the first frame update
    void Start()
    {
        if (pointToMoveTo == null)
        {
            pointToMoveTo = GameObject.Find(point.Value);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (pointToMoveTo.name != point.Value)
        {
            pointToMoveTo = GameObject.Find(point.Value);
        }

        if (Vector3.Distance(pointToMoveTo.transform.position, this.transform.position) < point_radius.Value)
        {
            this.transform.position = this.transform.position;
        }
        else
        {
            this.transform.position = Vector3.MoveTowards(this.transform.position, pointToMoveTo.transform.position, Time.deltaTime * moveSpeed.Value);
        }

    }
}
