using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using System.Xml;
using Newtonsoft.Json;
using System.Net;
using System.IO;
using System.Data;
using System.Text;
 

public class ApiDB : MonoBehaviour
{

    static string m_info;

    [SerializeField]
    Text text; // Text that you want to disable
    public Text dd;
    // Start is called before the first frame update
    void Start()
    {

        // text.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        //text.enabled = false;
        //if (Input.GetKeyDown(KeyCode.E)) // If the 'E' key is pressed,
        //{
        //    text.enabled = false; // Disable text
        //}
    }

    public void gettest1()
    {
        var ReturnValue = "";
        var url = "http://clockappservice.english4u.com.tw/api/test/Get02/9";
        ReturnValue = ApiReturnStr(url);
        dd.text = ReturnValue;

    }

    public void gettest2()
    {
        DataTable Returnda = new DataTable();
        var url = "http://clockappservice.english4u.com.tw/api/test/live";
        Returnda = ApiReturnData(url);
        foreach (DataRow row in Returnda.Rows)
        {
            //row.ItemArray[0]
            dd.text += row["Name"];
        }

    }

    public class NewCart
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }

    public static string ApiReturnStrPost(string url,string para)
    {
       
        var ReturnValue = "";
        byte[] bs = Encoding.ASCII.GetBytes(para);

        HttpWebRequest request = (System.Net.HttpWebRequest)WebRequest.Create(url);

        request.ContentLength = bs.Length;
        request.Method = WebRequestMethods.Http.Post;
        request.ContentType = "application/x-www-form-urlencoded";

        Stream reqStream = request.GetRequestStream();
        reqStream.Write(bs, 0, bs.Length);
        HttpWebResponse wr = (HttpWebResponse)request.GetResponse();
        DataTable ReturnData = new DataTable();
        if (wr.StatusCode == HttpStatusCode.OK)
        {
            using (var stream = wr.GetResponseStream())
            using (var reader = new StreamReader(stream))
            {
                var temp = reader.ReadToEnd();
                ReturnValue = temp;
                
            }
        }

        return ReturnValue;
    }

    public static DataTable ApiReturnTablePost(string url, string para)
    {
         
        byte[] bs = Encoding.ASCII.GetBytes(para);

        HttpWebRequest request = (System.Net.HttpWebRequest)WebRequest.Create(url);
        string ReturnValue = "";
        request.ContentLength = bs.Length;
        request.Method = WebRequestMethods.Http.Post;
        request.ContentType = "application/x-www-form-urlencoded";

        Stream reqStream = request.GetRequestStream();
        reqStream.Write(bs, 0, bs.Length);
        HttpWebResponse wr = (HttpWebResponse)request.GetResponse();
        DataTable ReturnData = new DataTable();
        DataTable ReturnData2 = new DataTable();
        if (wr.StatusCode == HttpStatusCode.OK)
        {
            using (var stream = wr.GetResponseStream())
            using (var reader = new StreamReader(stream))
            {
                var temp = reader.ReadToEnd();
                ReturnValue = temp;
                ReturnData = JsonConvert.DeserializeObject<DataTable>(temp);
                 
                ReturnData2 = formatDataTable(ReturnData);

                 
            }
        }

        return ReturnData2;
    }


    private  static DataTable formatDataTable(DataTable ReturnData) {
        DataTable dt2 = new DataTable();


        foreach (DataColumn col in ReturnData.Columns)
        {
            dt2.Columns.Add(col.ColumnName, typeof(string));
        }

        foreach (DataRow row in ReturnData.Rows)
        {
            var i = 0;
            DataRow temprow;
            temprow = dt2.NewRow();

            foreach (DataColumn col in ReturnData.Columns)
            {
                var myObject1 = (object)row[i];
                string myObjectString1 = myObject1.ToString();
                temprow[col.ColumnName] = myObjectString1;
                i = i + 1;
            }
            dt2.Rows.Add(temprow);


        }
        return dt2;
    }

    public static string ApiReturnStr(string url)
    {
        //var url = "http://clockappservice.english4u.com.tw/api/test/Get02/9"; 
        var ReturnValue = "";

        HttpWebRequest request = (System.Net.HttpWebRequest)WebRequest.Create(url);
        request.Method = WebRequestMethods.Http.Get;
        request.ContentType = "application/json";
        using (var response = (HttpWebResponse)request.GetResponse())
        {
            if (response.StatusCode == HttpStatusCode.OK)
            {
                using (var stream = response.GetResponseStream())
                using (var reader = new StreamReader(stream))
                {
                    var temp = reader.ReadToEnd();

                    string cart = JsonConvert.DeserializeObject<string>(temp);
                    ReturnValue = cart;

                }
            }
        };
        return ReturnValue;
    }

    public  static DataTable JsonToTable(string json) {
        DataTable ReturnData = new DataTable();
        DataTable ReturnData2 = new DataTable();
        
        ReturnData = JsonConvert.DeserializeObject<DataTable>(json);
        ReturnData2 = formatDataTable(ReturnData);

        return ReturnData;
    }


    

    static  IEnumerator IGetData(string url)
    {
        WWW www = new WWW(url);


        yield return www;//等待Web服务器的反应


        if (www.error != null)
        {
            m_info = www.error;
            yield return null;
        }


        m_info = www.text;
    }

    

    public  static DataTable ApiJsonToData(string url)
    {
        DataTable ReturnData = new DataTable();
         IGetData(url);
        var json = m_info;
        ReturnData = JsonToTable(json);
        
        return ReturnData;
    }

    public static DataTable ApiReturnData(string url)
    {
        // var url = "http://clockappservice.english4u.com.tw/api/test/live";
        DataTable ReturnData = new DataTable();
        DataTable ReturnData2 = new DataTable();
        HttpWebRequest request = (System.Net.HttpWebRequest)WebRequest.Create(url);
        request.Method = WebRequestMethods.Http.Get;
        request.ContentType = "application/json";
        using (var response = (HttpWebResponse)request.GetResponse())
        {
            if (response.StatusCode == HttpStatusCode.OK)
            {
                using (var stream = response.GetResponseStream())
                using (var reader = new StreamReader(stream, Encoding.UTF8))
                {
                    var temp = reader.ReadToEnd();
                    //JsonConvert.DeserializeObject'
                    //DataTable cart = JsonConvert.DeserializeObject<DataTable>(temp);
                    //ReturnData = cart;
                    
                    //--注意,不知為何,在unity 這裡轉換datatable後,
                    //直接 cart[0]["欄位名"] 為找不到,cart 的columns 又找的到欄位名
                    //--再注意有沒其它解法,不然就是接收端另外處理了!

                    ReturnData = JsonConvert.DeserializeObject<DataTable>(temp);

                    ReturnData2 = formatDataTable(ReturnData);


                }
            }
        };
        return ReturnData2;
    }


}
