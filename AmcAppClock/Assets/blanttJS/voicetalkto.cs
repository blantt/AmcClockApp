using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Profiling;


public class voicetalkto : MonoBehaviour {

	private XfSynthesizerListener dd;
	private VoiceBehavior tt; 

	 

	public GameObject objfunction;
	private static AndroidJavaClass UnityPlayer;
 

	public void blanttTalk(string mytalk){
		IFlyVoice.startSpeaking(mytalk);

	}


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {



	}
}
