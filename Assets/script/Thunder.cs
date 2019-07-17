using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;
using MidiJack;

public class Thunder : MonoBehaviour
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

        if (note == 42)
        {
            int x = Random.Range(-20, 60);

            int y = Random.Range(-20, 6);

            int z = Random.Range(-9, -10);

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
