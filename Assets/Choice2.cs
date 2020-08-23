using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Choice2 : MonoBehaviour
{
    public bool choice2, isPlaying;

    public int counting2, count2time = 150; //changePitchTime = 5, startingPitch = 4, 

    AudioSource audioChoice2;

    // Start is called before the first frame update
    void Start()
    {
        isPlaying = false;
        choice2 = false;
        audioChoice2 = GetComponent<AudioSource>();
        //audioChoice2.pitch = startingPitch;
        counting2 = 1;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerStay(Collider other)
    {
        if (other == other.gameObject.CompareTag("Player"))
        {
            counting2 = counting2 + 1;
            Debug.Log(counting2);
            //Some kind of sound feedback here.
            if (counting2 < count2time)
            {
                Debug.Log("PLAYING CHOICE2");
                //play sound
                //bend pitch down
                Invoke("PitchBend", 0.1f);
            }
            if (counting2 >= count2time && isPlaying == true)
            {
                choice2 = true;
                Invoke("StopAudio", 0.1f);
                //Destroy the parent to this game object.
            }
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other == other.gameObject.CompareTag("Player"))
        {
            counting2 = 0;
            Invoke("StopAudio", 0.1f);
        }
    }

    private void PitchBend()
    {
        if (isPlaying)
        {
            if (audioChoice2.pitch < 1.5f)
            {
                audioChoice2.pitch += (counting2 / 66) * Time.deltaTime;
                Debug.LogWarning("The pitch is " + audioChoice2.pitch);
            }
        }
        else
        {
            audioChoice2.Play();
            isPlaying = true;
        }
    }

    private void StopAudio()
    {
        audioChoice2.Stop();
        audioChoice2.pitch = 1;
        isPlaying = false;
    }
}

