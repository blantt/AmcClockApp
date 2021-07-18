using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

//騰飛語音錄音播放
public class voicetalk : MonoBehaviour {

	private AndroidJavaObject testobj = null;  
	private AndroidJavaObject playerActivityContext = null;  
	private static Text tt;

	//---這個函式是供android jar 能傳遞出來自android 的訊息
	public static void setmessage(string showText){

		GameObject root = GameObject.Find("setmessage");
		tt =root.GetComponent<Text>(); 
		if (showText == "clear") {
			tt.text = "";
		} else {
			tt.text = tt.text +"/"+ showText;

		}

	}


	public   void unitysendMessage(string javaclass,string javafunction){
		try  
		{  
		   //javaclass="com.example.cn_pa.myapplication.ttt3";
			//javafunction setContext
			AndroidJavaObject instance = new AndroidJavaClass(javaclass).CallStatic<AndroidJavaObject>("instance"); 
			using (var actClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer"))  
			{//获取当前的activity并保存下来  
				playerActivityContext = actClass.GetStatic<AndroidJavaObject>("currentActivity");  
			}  
			//---這裡是call非靜態方法
			instance.Call(javafunction, playerActivityContext);  
			 
		}  

		catch (System.Exception e)  
		{  
			//setmessage ("@error: "+e.Message);
		}  

	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
