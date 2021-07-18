using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doozy.Engine.UI;
using UIWidgets;
using UIWidgets.Extensions;
using UnityEngine.UI;
using Newtonsoft.Json;
using System.Net;
using System.IO;
using System.Data;
using UnityEngine.SceneManagement;
using Doozy.Engine.SceneManagement;

public class jsMaincom : MonoBehaviour
{
    public UIPopup myWaitpop;

    public bool isload = false;
    public Text txtPassword;
    public Text txtLogName;
    public int tempnum;
    public SceneLoader MySceneLoader;
    AsyncOperation operation_請假單;


    // Start is called before the first frame update
    void Start()
    {
        string url = "";
        url = BasicData.m_url班表資訊 + "/104259";
       //StartCoroutine(myGetData(url));
        BasicData.load人員基本資料("104259");
        txtLogName.text = BasicData.m_Item人員基本資料.FullName;
        StartCoroutine(AsyncLoading("menusub1"));

       


    }


  
 
     IEnumerator myGetData(string url)
    {
         
        WWW www = new WWW(url);


        yield return www;//等待Web服务器的反应


        if (www.error != null)
        {
             
            yield return null;
        }

        if (www.text !=  "") {
            DataTable tempda = new DataTable();
            tempda= ApiDB.JsonToTable(www.text);
            foreach (DataRow row in tempda.Rows)
            {
               BasicData.m_Item人員基本資料.UserName = row["UserName"].ToString();
                BasicData.m_Item人員基本資料.FullName = row["FullName"].ToString();
            }
        }

       

        
    }

    // Update is called once per frame
    void Update()
    {
         
    }

     

    public void beginload() {
        isload = true;
    }


    public void loadScene請假單()
    {
         
        myWaitpop.Show();
        operation_請假單.allowSceneActivation = true;

        myWaitpop.Hide();

    }

    IEnumerator AsyncLoading(string loadindex)
    {
        operation_請假單 = SceneManager.LoadSceneAsync(loadindex, LoadSceneMode.Additive);
        //loadscreen.SetActive(true);
        //allowSceneActivation !!! 設為true才會自動切換場景!
        operation_請假單.allowSceneActivation = false;
        
        while (!operation_請假單.isDone)
        {
            //float propress = operation_請假單.progress / 0.9f;
            //loadingSlider.value = propress;
            //loadingText.text = Mathf.FloorToInt(propress * 100f).ToString();
            yield return null;

        }
       

    }

    public void hideloading()
    {
       // SceneManager.LoadScene("menusub1");
        myWaitpop.Hide();
    }

 
}
