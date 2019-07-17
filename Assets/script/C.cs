using UnityEngine;
using MidiJack;
using System.Collections;
using System.Collections.Generic;



public class C : MonoBehaviour
{
	[SerializeField] private GameObject Cam;
	[SerializeField] private GameObject Cam2;

	void action (MidiChannel channel, int note)
	{
		if (note == 42)
		{
			Cam.SetActive(!Cam.activeSelf);

			Cam2.SetActive(!Cam2.activeSelf);
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