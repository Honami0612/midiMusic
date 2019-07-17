using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;
using MidiJack;

public class kick1 : MonoBehaviour
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

        if (note == 37)
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





       /*if (Input.GetKey(KeyCode.A))
        {
            number = UnityEngine.Random.Range(0, playable.Length);

        if(call==false)  One();
        
       if(call==true)
        {
                //number = Random.Range(0, playable.Length);
                pushtime = DateTime.Now;
                millstart = start.Millisecond;
                millsecond = pushtime.Millisecond;
                now = millsecond - millstart;

                if(now<500)
                {
                    Debug.Log("action");
                }else{
                    Debug.Log("play");
                    playable[number].Play();
                }
            
        }

        } 

    }

    void One()
    {
        playable[number].Play();
        call = true;
        Timestart();
        
    }

    void Timestart()
    {
        start = DateTime.Now;
    }
	//nowTime += Time.deltaTime;



	if(Input.GetKeyDown(KeyCode.A))
	{
		push = true;
		Debug.Log("double");
		//nextTime += Time.deltaTime;
		if((nowTime-nextTime)<0.0165f)
		{
			Debug.Log("scale");
			this.transform.localScale = new Vector3(2, 2, 2);
			playable[number].Play();
			Debug.Log(nowTime);
			nowTime = 0f;
			//nextTime = 0f;
		}else
		{
			Debug.Log("nodouble");
			playable[number].Play(); 
			Debug.Log(nowTime);
			nowTime = 0f;
			//nextTime = 0f;
		}
	}




 *public bool push=false; //最初に移動ボタンを押したがどうか
 *public float nextButtonDownTime; //次にボタンが押されるまでの時間
 *private float nowTime=0f; //最初にボタンが押されてからの経過時間
 *push=trueになった時間をnowTime=０に初期化し、時間計算を行う
 *if(push){
 *nowTime+=Time.deltaTime;
 *if(nowTime>nextButtonDownTime){
 *push=false;
 *}
 *}




 push = true;
            number = Random.Range(0, playable.Length);

            if (push)
            {
                nowTime += Time.deltaTime;
                if (nowTime > 0.16f)
                {
                    push = false;

                }
            }


        }
 
        if(push){
            playable[number].Play();
        }else{
            Debug.Log("double");
        */