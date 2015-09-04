using UnityEngine;
using System.Collections;

public class Tran_testAudio : MonoBehaviour {

	void Update ()
    {
       
	    if(Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Tran_AudioManager>().Start_Audio();
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            GetComponent<Tran_AudioManager>().Exit_Audio();
        }
    }
}
