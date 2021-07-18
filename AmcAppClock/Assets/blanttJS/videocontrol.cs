using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class videocontrol : MonoBehaviour {
	public VideoPlayer vPlayer;
	public Slider sliderVideo;
	private int hour, mint;
	private float time;
	private float time_Count;
	private float time_Current;
	// Use this for initialization
	void Start () {
		vPlayer.Play ();
		//sliderVideo.onValueChanged.AddListener(delegate { ChangeVideo(sliderVideo.value); });
	}

	/// <summary>
	///     改变视频进度
	/// </summary>
	/// <param name="value"></param>
	public void ChangeVideo(float value) {
		if (vPlayer.isPrepared)
		{
			vPlayer.time = (long)value+100f;
			Debug.Log("VideoPlayer Time:"+vPlayer.time);
			time = (float)vPlayer.time;
			hour = (int)time / 60;
			mint = (int)time % 60;
			//text_Time.text = string.Format("{0:D2}:{1:D2}", hour.ToString(), mint.ToString());
		}
	}

	// Update is called once per frame
	void Update () {

	}

	public void play(){
		vPlayer.Play ();
	}

	public void stop(){
		vPlayer.Stop ();
	}

	public void run1(){

		vPlayer.time = vPlayer.time+50f;
	}
	public void run2(){

		vPlayer.time = vPlayer.time-50f;
	}

	 

}
