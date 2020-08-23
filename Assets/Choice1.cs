using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Choice1 : MonoBehaviour
{
    public bool choice1, isPlaying;

    public int counting1, count1time = 150; //changePitchTime = 5, startingPitch = 4, 

    AudioSource audioChoice1;

    // Start is called before the first frame update
    void Start()
    {
        isPlaying = false;
        choice1 = false;
        audioChoice1 = GetComponent<AudioSource>();
        //audioChoice2.pitch = startingPitch;
        counting1 = 1;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerStay(Collider other)
    {
        if (other == other.gameObject.CompareTag("Player"))
        {
            counting1 = counting1 + 1;
            Debug.Log(counting1);
            //Some kind of sound feedback here.
            if (counting1 < count1time)
            {
                Debug.Log("PLAYING CHOICE2");
                //play sound
                //bend pitch down
                Invoke("PitchBend", 0.1f);
            }
            if (counting1 >= count1time && isPlaying == true)
            {
                choice1 = true;
                Invoke("StopAudio", 0.1f);
                //Destroy the parent to this game object.
            }
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other == other.gameObject.CompareTag("Player"))
        {
            counting1 = 0;
            Invoke("StopAudio", 0.1f);
        }
    }

    private void PitchBend()
    {
        if (isPlaying)
        {
            if (audioChoice1.pitch < 1.5f)
            {
                audioChoice1.pitch += (counting1 / 66) * Time.deltaTime;
                Debug.LogWarning("The pitch is " + audioChoice1.pitch);
            }
        }
        else
        {
            audioChoice1.Play();
            isPlaying = true;
        }
    }

    private void StopAudio()
    {
        audioChoice1.Stop();
        audioChoice1.pitch = 1;
        isPlaying = false;
    }
}

