using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doozy.Engine.UI;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Data;
using System;
 

public class jsLogin : MonoBehaviour
{
     
    public UIPopup mypop;
    public Text txtUserNane;
    public Text txtPassword;
    public float baseWidth = 1080;
    public float baseHeight = 1920;
    public Camera mycam;
    public Doozy.Engine.SceneManagement.SceneLoader mySence;
    public Text message;

    // Start is called before the first frame update
    void Start()


    {
        //Object vvv;
        //vvv = GameObject.Find("myvar");
       

        // mycam.aspect = this.baseWidth / this.baseHeight;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Awake()
    {

        //CanvasScaler canvasScaler = GetComponent<CanvasScaler>();

        //float screenWidthScale = Screen.width / canvasScaler.referenceResolution.x;
        //float screenHeightScale = Screen.height / canvasScaler.referenceResolution.y;

        //canvasScaler.matchWidthOrHeight = screenWidthScale > screenHeightScale ? 1 : 0;
    }

    public void loginnsmv ()
    {
       
        try
        {
            message.text += "讀取中5";
            WebService2 ddd = new WebService2();
            string ss;
            //string UserName;
            //string PassWord;
            //UserName = txtUserNane.text;
            //PassWord = txtPassword.text;

            //ss = ddd.CheckLogin(UserName, PassWord);
            //if (ss == "0")
            //{
            //    GameData.UserName = UserName;
            //    mySence.LoadSceneAsync();
            //}
            //if (ss == "1")
            //{

            //    mypop.Show();
            //}
            message.text += "讀完成";
        }
        catch (Exception ex)  // CS0168
        {
            message.text += ex.Message;
             message.text += ex.InnerException.Message;
            message.text += "error end";

        }


    


       
    }

    public void hidepop() {
        mypop.Hide();
    }
    public void showpop()
    {
        mypop.Show();
    }

}
