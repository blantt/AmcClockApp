using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEditor;

public class blanttEdit : MonoBehaviour {
    [Range(1, 10)]
    public float mySliderFloat;
    public int editNum;
    public Color color;
    public Vector3 position;
    public bool check;
    public int value1;
    public int value2;
    public enum customExpand
    {
        美美 , 阿呆
    };
    public customExpand expand;
    // Use this for initialization
    void Start () {
	     
	}
	
	// Update is called once per frame
	void Update () {
		 

	}
}
