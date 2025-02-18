﻿
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Discription:A String Extension Powered byMemoryC 
/// Functions: extension a string text to showAsToast, toJavaString, or Speak out
/// CopyRight:MemoryC
/// Time:2017.02.15
/// </>
/// </summary>
public static class MemoryCString {
	public static void showAsToast(this string text ,AndroidJavaObject activity=null){
		Debug.Log (text);
		if (activity == null) {
			AndroidJavaClass UnityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
			activity= UnityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
		}
		AndroidJavaClass Toast = new AndroidJavaClass("android.widget.Toast");
		AndroidJavaObject context =activity.Call<AndroidJavaObject>("getApplicationContext");
		activity.Call("runOnUiThread", new AndroidJavaRunnable(() => {
			AndroidJavaObject javaString = new AndroidJavaObject("java.lang.String", text);
			Toast.CallStatic<AndroidJavaObject>("makeText", context, javaString, Toast.GetStatic<int>("LENGTH_SHORT")).Call("show");
		}
		));
	}

	public static AndroidJavaObject toJavaString(this string CSharpString){
                return new AndroidJavaObject ("java.lang.String", CSharpString);

    }
       

        /// <summary>
        /// Speak the specified text and voicer.
        /// </summary>
        /// <param name="text">Text.</param>
        /// <param name="voicer">Voicer.</param>
        public static void speak(this string text,string voicer="xiaoyan"){
                IFlyVoice.startSpeaking (text,voicer);
        }
	 
 
	 

}

