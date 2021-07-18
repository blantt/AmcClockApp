using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Data;
using Doozy.Engine.UI;
using System.Threading;

public class Globe
{
    public static string nextSceneName;
}

public class load2 : MonoBehaviour
{
    public UIPopup myWaitpop;
    AsyncOperation operation_請假單;

    private bool bload = false;

    public GameObject loadscreen;

    public Slider loadingSlider;

    public Text loadingText;

    public Text test1;
    public float testnumber;

    private string m_info;

    private float loadingSpeed = 1;

    private float targetValue;

    //public AsyncOperation operation;

    // Use this for initialization
    void Start()
    {
        loadingSlider.value = 0.0f;

        //if (SceneManager.GetActiveScene().name == "load1")
        //{

        //    //啟動協程
        //    StartCoroutine(AsyncLoading());
        //}
    }

    public void loadsence2(string loadindex)
    {
        SceneManager.LoadSceneAsync(loadindex);
    }

    public void loadsence(string loadindex)
    {
        Debug.Log("starut");
 
        StartCoroutine(loaddefault2());
        StartCoroutine(AsyncLoading(loadindex));

        // StartCoroutine(IGetData(BasicData.m_urlperson));


        // StartCoroutine(loaddefault3());


    }


    public void loaddefalut(string loadindex)
    {

        StartCoroutine(IGetData(BasicData.m_urlperson));

    }


    public string url = "http://clockappservice.english4u.com.tw/api/funcPerson/admin";


     IEnumerator IGetData(string url)
    {
        WWW www = new WWW(url);


        yield return www;//等待Web服务器的反应


        if (www.error != null)
        {
            m_info = www.error;
            yield return null;
        }
        DataTable tt = new DataTable();
       tt= ApiDB.JsonToTable(www.text);
        BasicData.m_data_person = tt;
        m_info = www.text;
    }


    private void load5() {
        DataTable da = new DataTable();
        using (WWW www = new WWW(url))
        {
            // Wait for download to complete
            var t = www.text;

           da= ApiDB.JsonToTable(www.text);

            // assign texture
            //Renderer renderer = GetComponent<Renderer>();
            //renderer.material.mainTexture = www.textureNonReadable;
        }


    }

    
    IEnumerator loaddefault2()
    {

         
        Debug.Log("002");

        yield return 0;
        Debug.Log("004");
        while (1 == 1)
        {
            testnumber = testnumber + 1;
            test1.text = testnumber.ToString();

            yield return 0;
        }


    }

    IEnumerator AsyncLoading(string loadindex)
    {
        operation_請假單 = SceneManager.LoadSceneAsync(loadindex, LoadSceneMode.Additive);
        //loadscreen.SetActive(true);
        //allowSceneActivation !!! 設為true才會自動切換場景!
        operation_請假單.allowSceneActivation = true;
        myWaitpop.Show();
        while (!operation_請假單.isDone)
        {
            //float propress = operation_請假單.progress / 0.9f;
            //loadingSlider.value = propress;
            //loadingText.text = Mathf.FloorToInt(propress * 100f).ToString();
            yield return null;

        }
        myWaitpop.Hide();

      
    }

    // Update is called once per frame
    void Update()
    {
       
        if (bload == true) {
            operation_請假單.allowSceneActivation = true;
        }

    }

    public void loadactive() {
        bload = true;
       
    }
    public void loadPOP()
    {
        myWaitpop.Show();

    }
}