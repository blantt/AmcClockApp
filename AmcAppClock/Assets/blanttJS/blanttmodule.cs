using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.Data;
using UnityEngine.UI;
using UnityEngine.Sprites;
using System.Text.RegularExpressions;
using UnityEngine.SceneManagement;
public class blanttmodule : MonoBehaviour {

	// Use this for initialization
	void Start () {
        ScreenSize();

    }
	
	// Update is called once per frame
	void Update () {



	}


	//---設定APK 到手機後,實機的長寬 
	public void ScreenSize(){
		Screen.SetResolution(1280, 800, true);
	}

	public void func取得某物件上的一點componet(){
		//vvv=	GameObject.Find ("myvar");
	    //enemyHP = vvv.transform.GetComponent<btntest> ();
		//enemyHP.someGlobal=0;
         
	}

	//---檢查是否有特殊字元 
	public bool checkSpecialText(string ss){

		Regex reg = new Regex("^[^~!@#$%^&*()_+]+$");
		Match m =  reg.Match(ss);

		if (m.Success) {
			return true;
		} else {
			return false;
		}

	}

	public void setplace(){

		GameObject.Find("unitychan").transform.position = new Vector3 (-0.6f,-0.13f,8.33f);
	}

	// 每隔一段時間執行
	private IEnumerator delay(float time ){
		yield return new WaitForSeconds(time);

	}

	// 每隔一段時間執行(執行)------
	public void godelay(){
		StartCoroutine(delay(2f)); 
	}

	//-----取亂數-----
	public void blanttRandom(){

		Random random1 = new Random(); 
		int mycount=	Random.Range(3,9);

		Hashtable mytable1;
		mytable1 = new Hashtable ();

		//---如果要亂數不重覆則跑下面 用hashtable (也可用陣列 )
		while ( mytable1.ContainsValue(mycount)){
			mycount=	Random.Range(3, 9);
		}  ;

		mytable1.Add (mycount,mycount);

	}

	//----複製物件
	public void copyObject(){
		GameObject Tempnew;
		Tempnew = Instantiate(gameObject);//複製copyGameObject物件(連同該物件身上的腳本一起複製)

	}

	//----物件屬性相關修改
	public void changeObjectSetting(){
		//---更改透明度==============
		Image myimage;
		myimage = gameObject.GetComponent<Image>();
		myimage.color=new Color(1f,1f,1f,0.2f);  

		//---更改位置
		gameObject.transform.position   = new Vector3( gameObject.transform.position.x+1 ,  gameObject.transform.position.y +1 ,  gameObject.transform.position.z+1 );
		//-----縮放
		gameObject.transform.localScale = new Vector3(2,2, 1);
        

	}

    public void LoadSencebyName(string ScenceName) {
        SceneManager.LoadScene(ScenceName);
    }



}
