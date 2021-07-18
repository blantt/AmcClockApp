using UnityEngine;
using System.Collections;

public class XfInitListener : AndroidJavaProxy {

	public XfInitListener():base("com.iflytek.cloud.InitListener"){

	}

	public void onInit(int code) {
		//ErrorCode.SUCCESS=0;
		if (code !=0 ) {
			showTip ("初始化失败,错误码："+code);
		}         
	}

	void showTip(string text){
		//这里请参考MemoryC专栏 Unity3D调用Android功能与组件（一）		 
		AndroidJavaClass UnityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
		AndroidJavaObject currentActivity= UnityPlayer.GetStatic<AndroidJavaObject>("currentActivity");;
		AndroidJavaClass Toast = new AndroidJavaClass("android.widget.Toast");
		AndroidJavaObject context =currentActivity.Call<AndroidJavaObject>("getApplicationContext");
		currentActivity.Call("runOnUiThread", new AndroidJavaRunnable(() => {
		AndroidJavaObject javaString = new AndroidJavaObject("java.lang.String", text);
		Toast.CallStatic<AndroidJavaObject>("makeText", context, javaString, Toast.GetStatic<int>("LENGTH_SHORT")).Call("show");
		}
		));
		 
	}
}