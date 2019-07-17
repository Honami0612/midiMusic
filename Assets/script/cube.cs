using UnityEngine;
using MidiJack;
using System.Collections;
using System.Collections.Generic;


public class cube : MonoBehaviour
{
	private GameObject Cube;

	void NoteOn(MidiChannel channel, int note, float velocity)
	{
		Cube = GameObject.Find ("Cube");

		if (note == 40) {
			Debug.Log ("NoteOn: " + channel + "," + note + "," + velocity);

			float r = Random.Range (1, 255);
			r = r / 100;

			float g = Random.Range (1, 255);
			g = g / 100;

			float b = Random.Range (1, 255);
			b = b / 100;

			Cube.GetComponent<Renderer> ().material.color = new Color (r, g, b, 1.0f);

			if (velocity >= 0.8) 
			{
                Cube.transform.localScale = new Vector3 (3, 3, 3);
			} 

			else if (velocity >= 0.4)
			{
                Cube.transform.localScale = new Vector3 (2, 2, 2);
			}
				
			else 
			{
                Cube.transform.localScale = new Vector3 (1, 1, 1);
			}
		}

		Invoke ("Shift", 0.3f);
	}

	void OnEnable()
	{
		MidiMaster.noteOnDelegate += NoteOn;
	}

	void OnDisable()
	{
		MidiMaster.noteOnDelegate -= NoteOn;
	}

	void Shift ()
	{
		Cube.transform.localScale = new Vector3 (0, 0, 0);
	}
		
}
