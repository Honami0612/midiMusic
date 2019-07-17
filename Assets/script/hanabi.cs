using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;
using MidiJack;

public class hanabi : MonoBehaviour
{


    public GameObject circle;

    int number;

    // Use this for initialization
    void Start()
    {
        Application.targetFrameRate = 60;

    }

    void action(MidiChannel channel, int note)
    {

        if (note == 41)
        {
            int x = Random.Range(-16, 30);

            int y = Random.Range(-17, 6);

            int z = Random.Range(-1, -5);

            circle.transform.position = new Vector3(x, y, z);


            GameObject.Instantiate(circle);
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
