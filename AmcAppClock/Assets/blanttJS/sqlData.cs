using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.Data;
using UnityEngine.UI;
using UnityEngine.Sprites;

public class sqlData : MonoBehaviour {
    public string NewSence;
 //   private void updateExamList(){

	//	string sql2  = "";
	//	sql2="  insert CatExamList (buildID,ExamID,catid) values('XXXXXXXXXXXX')  ";
	//	ExceData (sql2);
	//}

	//private DataTable getexamlist(){
	//	DataTable dt = new DataTable ("Table");
	//	string sql2  = "";
	//	sql2="  select  BuildID,ExamID,catid  from  CatExamList where catid='XXXXXXXXXXXXXX' ";
	//	dt = Selectdatatable(sql2);
	//	return dt;
	//} 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	//public DataTable Selectdatatable(string sql)
	//{

	//	//WebService ddd=new WebService();
	//	//string ss;
	//	//ss=	ddd.HelloWorld ();
	//	//DataTable dt;

	//	//dt=ddd.getData (sql);
	//	//return dt;
	//}

	public void ExceData( string sql)
	{

		//WebService ddd=new WebService();
		//ddd.ExecData (sql);
	}

    public void test1() {
        //WebService2 ddd = new WebService2();
        //string ss;
        //string UserName;
        //string PassWord;
        //UserName = "104259";
        //PassWord = "bb";
        //ss = ddd.CheckLogin(UserName, PassWord);
        //if (ss == "0") {
        //    NewSence = "yes";
        //}
        //if (ss == "1")
        //{
        //    NewSence = "no";
        //}

    }

}
