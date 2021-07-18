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



public class BasicData : MonoBehaviour
{

    public static DataTable m_data_person = null;
    public static DataTable m_data_假別 = null;
    private static string m_info;
    public static string m_url班表資訊 = "http://clockappservice.english4u.com.tw/api/funcPersonSet";
    public static string m_urlperson = "http://clockappservice.english4u.com.tw/api/funcPerson/admin";
    public static string m_url假別 = "http://clockappservice.english4u.com.tw/api/func假別/admin";
    public static class_人員基本資料 m_Item人員基本資料 = new class_人員基本資料();

    public class class_人員基本資料
    {
        public string UserName = "";
        public string FullName = "";
        public string RosterN = "";
        public string ClassID = "";
        public string ClassName = "";
        public string SHH = "";
        public string EHH = "";
        public string SleepHH1 = "";
        public string SleepHH2 = "";
        public string UserAgent = "";
        public string UserAgentN = "";
        public string UserSee = "";
        public string UserSeeN = "";
        public string UserSee2 = "";
        public string UserSee2N = "";
        public string UserBoss = "";
        public string UserBossN = "";

    }

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

    }

    public static void load人員基本資料(string UserName)
    {
        if (m_Item人員基本資料.UserName == "")
        {

          


            DataTable Returnda = new DataTable();
            Returnda = ApiDB.ApiReturnData(m_url班表資訊 + "/"+ UserName);
           
            foreach (DataRow row in Returnda.Rows)
            {
                m_Item人員基本資料.UserName = row["UserName"].ToString();
                m_Item人員基本資料.FullName = row["FullName"].ToString();
                m_Item人員基本資料.ClassID = row["ClassID"].ToString();
                m_Item人員基本資料.ClassName = row["ClassName"].ToString();
                m_Item人員基本資料.EHH = row["EHH"].ToString();
                m_Item人員基本資料.RosterN = row["RosterN"].ToString();
                m_Item人員基本資料.SHH = row["SHH"].ToString();
                m_Item人員基本資料.SleepHH1 = row["SleepHH1"].ToString();
                m_Item人員基本資料.SleepHH2 = row["SleepHH2"].ToString();
                m_Item人員基本資料.UserAgent = row["UserAgent"].ToString();
                m_Item人員基本資料.UserAgentN = row["UserAgentN"].ToString();
                m_Item人員基本資料.UserBoss = row["UserBoss"].ToString();
                m_Item人員基本資料.UserBossN = row["UserBossN"].ToString();
                m_Item人員基本資料.UserSee = row["UserSee"].ToString();
                m_Item人員基本資料.UserSee2 = row["UserSee2"].ToString();
                m_Item人員基本資料.UserSee2N = row["UserSee2N"].ToString();
                m_Item人員基本資料.UserSeeN = row["UserSeeN"].ToString();
            }

            //if (Returnda.Rows.Count > 0)
            //{
            //    m_Item人員基本資料.UserName = Returnda.Rows[0]["UserName"].ToString();
            //    m_Item人員基本資料.FullName = Returnda.Rows[0]["FullName"].ToString();
            //    m_Item人員基本資料.ClassID = Returnda.Rows[0]["ClassID"].ToString();
            //    m_Item人員基本資料.ClassName = Returnda.Rows[0]["ClassName"].ToString();
            //    m_Item人員基本資料.EHH = Returnda.Rows[0]["EHH"].ToString();
            //    m_Item人員基本資料.RosterN = Returnda.Rows[0]["RosterN"].ToString();
            //    m_Item人員基本資料.SHH = Returnda.Rows[0]["SHH"].ToString();
            //    m_Item人員基本資料.SleepHH1 = Returnda.Rows[0]["SleepHH1"].ToString();
            //    m_Item人員基本資料.SleepHH2 = Returnda.Rows[0]["SleepHH2"].ToString();
            //    m_Item人員基本資料.UserAgent = Returnda.Rows[0]["UserAgent"].ToString();
            //    m_Item人員基本資料.UserAgentN = Returnda.Rows[0]["UserAgentN"].ToString();
            //    m_Item人員基本資料.UserBoss = Returnda.Rows[0]["UserBoss"].ToString();
            //    m_Item人員基本資料.UserBossN = Returnda.Rows[0]["UserBossN"].ToString();
            //    m_Item人員基本資料.UserSee = Returnda.Rows[0]["UserSee"].ToString();
            //    m_Item人員基本資料.UserSee2 = Returnda.Rows[0]["UserSee2"].ToString();
            //    m_Item人員基本資料.UserSee2N = Returnda.Rows[0]["UserSee2N"].ToString();
            //    m_Item人員基本資料.UserSeeN = Returnda.Rows[0]["UserSeeN"].ToString();



            //}


        }

    }

    public static void loadDefaule()
    {
        if (m_data_person == null)
        {
            DataTable Returnda = new DataTable();
            Returnda = ApiDB.ApiReturnData(m_urlperson);
            m_data_person = Returnda;
        }

        if (m_data_假別 == null)
        {
            DataTable Returnda = new DataTable();
            Returnda = ApiDB.ApiReturnData(m_url假別);
            m_data_假別 = Returnda;
        }
    }

    public static void loadDefaule2()
    {
        if (m_data_person == null)
        {
            DataTable Returnda = new DataTable();
            Returnda = ApiDB.ApiJsonToData(m_urlperson);
            m_data_person = Returnda;
        }

        if (m_data_假別 == null)
        {
            DataTable Returnda = new DataTable();
            Returnda = ApiDB.ApiJsonToData(m_url假別);
            m_data_假別 = Returnda;
        }
    }



}
