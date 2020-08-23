using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoiceArrival : MonoBehaviour
{
    public GameObject Choice1, Choice2, player, choiceTrigger;

    // Start is called before the first frame update
    void Start()
    {
        ////Choice1.SetActive(false);

        ////Choice2.SetActive(false);

        Choice1.GetComponent<BoxCollider>().enabled = false;
        Choice2.GetComponent<BoxCollider>().enabled = false;
        choiceTrigger = gameObject.transform.parent.gameObject;  //GetComponentInParent<GameObject>();
        //Debug.LogWarning("<<<<<<<<<<<< " + choiceTrigger.name + " >>>>>>>>>>>>>>>>>");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        //Debug.LogWarning("this sees " + other.name);
        if (other == other.gameObject.CompareTag("Player"))
        {
            player = other.gameObject;
            transform.LookAt(player.transform);
            ////this.gameObject.GetComponent<BoxCollider>().isTrigger = false;
            gameObject.GetComponent<BoxCollider>().enabled = false;
            gameObject.GetComponent<MeshRenderer>().enabled = false;

            //Debug.LogWarning("PLAYER SEES CHOICE!!!!!!!!!!!!!!!!<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");
            Invoke("Welcome", 0.1f);
        }
    }

    void Welcome()
    {

        //Play sound. "Oh you found me!"

        //Play question.

        //Turn on Choices.
        Choice1.SetActive(true);

        Choice2.SetActive(true);

        Choice1.GetComponent<BoxCollider>().enabled = true;
        Choice2.GetComponent<BoxCollider>().enabled = true;

        //this.gameObject.transform.GetComponentInParent<Transform>().LookAt(player.gameObject.transform);

        //this.gameObject.SetActive(false);
    }      
}
