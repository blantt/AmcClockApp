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
using System.Threading;


public class tt1 : MonoBehaviour
{
    public UIPopup myWaitpop;
    public Text temptxt;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ttt(){
        myWaitpop.Show();
       //  Thread.Sleep(2000);
       // SceneManager.LoadScene("aa2");

    }

    public void ttt2()
    {


        //  StartCoroutine(DisplayLoadingScreen("aa2"));
        // SceneManager.LoadScene("aa2");

        StartCoroutine(A());
        var ss = "";
       // myWaitpop.Hide();
    }

    IEnumerator A()
    {
        myWaitpop.Show();
        
        yield return new WaitForSeconds(3);

        SceneManager.LoadScene("aa2");
        myWaitpop.Hide();
        yield return 0;

    }

    IEnumerator B()
    {
        Thread.Sleep(2000);
        yield return 0;
    }

    IEnumerator DisplayLoadingScreen(string sceneName)////(1)
    {
        Thread.Sleep(2000);
        yield return 0;
        //for ( float i =0; i < 5; i += Time.deltaTime )
        //{
        //    yield return 0;
        //}

        //AsyncOperation async = Application.LoadLevelAsync(sceneName);////(2)
        //Thread.Sleep(2000);

        //while (!async.isDone)////(3)
        //{
        //    //loadText.text = (async.progress * 100).ToString() + "%";////(4)
        //    //loadImage.transform.localScale = new Vector2(async.progress, loadImage.transform.localScale.y);
        //    yield return null;
        // }
    }


}
