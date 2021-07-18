using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class objAction : MonoBehaviour {
	private Animator animator;
	// Use this for initialization
	public Animator actor1;
	private void toPlay(){
		
		animator.Play ("ac1_2");

	}

	void Start () {
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		AnimatorStateInfo info = actor1.GetCurrentAnimatorStateInfo(0);
		// 判断动画是否播放完成
		if (info.normalizedTime >= 1.0f)
		{
		  
		}
	}
}
