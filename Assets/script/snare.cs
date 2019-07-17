using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;
using MidiJack;

public class snare : MonoBehaviour
{

    public PlayableDirector[] playable;
    int number;


    // Use this for initialization
    void Start()
    {
        Application.targetFrameRate = 60;
       
    }

    // Update is called once per frame
    void action(MidiChannel channel, int note)
    {

        if (note == 38)
        {
            number = Random.Range(0, playable.Length);
            playable[number].Play();
        }
    }

    void OnEnable()
    {
        MidiMaster.noteOffDelegate += action;
    }

    void OnDisable()
    {
        MidiMaster.noteOffDelegate -= action;
    }
}