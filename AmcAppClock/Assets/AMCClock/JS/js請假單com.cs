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
using System;
using System.Globalization;

public class js請假單com : MonoBehaviour

{

    public myComboIcon combo代理人1;
    public myComboIcon combo代理人2;
    public myComboIcon combo監交人1;
    public myComboIcon combo監交人2;
    public myComboIcon combo假別;


    public myDateTime dd;

    public UIPopup myWaitpop;

    public bool bload = true;
   
    // Start is called before the first frame update
    void Start()
    {
        //getBasicData();
        //loadDefault();
        // myWaitpop.Show();
        var dd = "";
    }

    // Update is called once per frame
    void Update()
    {

        //if (bload == true) {

        //    loadDefault();
        //    bload = false;
        //}
         
          
    }

    void Awake()
    {

        BasicData.loadDefaule();
        loadDefault();



    }


    public void loadDefault()
    {
        if (combo代理人1 != null)
        {
            loadComboIconsDefault(combo代理人1.myAutoComboboxIcons, BasicData.m_data_person);
            if (BasicData.m_Item人員基本資料.UserAgent != "") {
                combo代理人1.setComboSelectByKey(BasicData.m_Item人員基本資料.UserAgent);
            }
           
        }

        if (combo代理人2 != null)
        {
             loadComboIconsDefault(combo代理人2.myAutoComboboxIcons, BasicData.m_data_person);
            //if (BasicData.m_Item人員基本資料.UserAgent != "")
            //{
            //    combo代理人2.setComboSelectByKey(BasicData.m_Item人員基本資料.UserAgent);
            //}
        }

        if (combo監交人1 != null)
        {
            loadComboIconsDefault(combo監交人1.myAutoComboboxIcons, BasicData.m_data_person);
        }

        if (combo監交人2 != null)
        {
            loadComboIconsDefault(combo監交人2.myAutoComboboxIcons, BasicData.m_data_person);
        }

        if (combo假別 != null)
        {
            loadComboIconsDefault(combo假別.myAutoComboboxIcons, BasicData.m_data_假別);
        }

     

    }
 


    public void loadtest() {

        
        setComboSelectByKey(combo代理人1.myAutoComboboxIcons, "104259");


    }

    private void setComboSelectByKey(AutoComboboxIcons tempcombo,string key) {
        int iselect = -1;
        foreach (ListViewIconsItemDescription item in tempcombo.Combobox.ListView.DataSource)
        {
            iselect += 1;
            var d = item.Name;
            if (d == key)
            {
                break;
            }
        }
        tempcombo.Combobox.ListView.SelectedIndex = iselect;

    }

    public void loadComboIconsDefault(AutoComboboxIcons tempcombo,DataTable tempDa=null) {
       

        AutoComboboxIcons tempAutoCombo;
        
        tempAutoCombo = tempcombo.GetComponent<AutoComboboxIcons>();
        tempAutoCombo.Autocomplete.gameObject.SetActive(false);

        //string ApiUrl = tempUIControl.m_ApiUrl;
        //string Apipara = tempUIControl.m_Apipara;
        tempcombo.Combobox.ListView.DataSource.Clear();
        AddComboItem(tempcombo, "", "");
        //if (tempDa == null) {
        //    if (ApiUrl == "")
        //    {
        //        return;
        //    }
        //    else {
        //        tempDa = ApiDB.ApiReturnData(ApiUrl);

        //    }

        //}

        if (tempDa != null)
        {

            foreach (DataRow row in tempDa.Rows)
            {

                string name1 = row["name1"].ToString();
                string name2 = row["name2"].ToString();

                AddComboItem(tempcombo, name1, name2);
            }

        }




    }


    public void getBasicData() {
        //http://clockappservice.english4u.com.tw/api/funcPerson/104259

        if (BasicData.m_data_person == null) {

            BasicData.m_data_person = ApiDB.ApiReturnData(BasicData.m_urlperson );
        }
        if (BasicData.m_data_假別 == null)
        {
            BasicData.m_data_假別 = ApiDB.ApiReturnData(BasicData.m_url假別);
        }


    }

   

    public void AddComboItem(AutoComboboxIcons tempcombo, string str1, string str2)
    {
        var new_item = new ListViewIconsItemDescription()
        {
            Name = str1,
            Name2 = str2
        };
   
        tempcombo.Combobox.ListView.DataSource.Add(new_item);
    }

    public void showloading() {

        myWaitpop.Show();

    }

    public void hideloading() 
    {
        myWaitpop.Hide();
    }

    public void test() {
        string aaa;
        aaa ="aaa";
        
    }


}
