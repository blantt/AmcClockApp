using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//------物件移動
public class myposition : MonoBehaviour {
	//public GameObject PathA;//起點
	 private GameObject PathB;//終點
//	public GameObject Obj;//要移動的物件
	 
	public float firstSpeed;//紀錄第一次移動的距離
	// Use this for initialization

	public float roate_Z;
	public bool isbasic; //true 時本體,不移動也不消失,供後面複製用
	void Start () {
		 
		PathB=new GameObject();  //PathB 是預設截止的位置
		PathB.transform.position   = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y-5, gameObject.transform.position.z);
        
	}
	
	// Update is called once per frame
	void Update () {
		if (isbasic == false) {
			gameObject.transform.Rotate (0,0,roate_Z);
			gameObject.transform.position += new Vector3( 0f,  firstSpeed, 0f);
			calculateNewSpeed ();
			//讓使用者每按一次 ↑ 時都移動一次，這只是為了方便看出每次移動的距離
			if (Input.GetKeyDown(KeyCode.UpArrow))
			{
				//先移動過後，再計算新的 speed
				gameObject.transform.position += new Vector3( 0f,firstSpeed, 0f);
				//gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, PathB.transform.position, speed);
				//speed = calculateNewSpeed();
			}

			if (Input.GetKeyDown(KeyCode.A))
			{
				//先移動過後，再計算新的 speed
				gameObject.transform.position += new Vector3( 0f,firstSpeed, 0f);
				//	speed = calculateNewSpeed();
			}
		
		}
 
	}

	void   calculateNewSpeed()
	{
		//因為每次移動都是 Obj 在移動，所以要取得 Obj 和 PathB 的距離
		float tmp = Vector3.Distance(gameObject.transform.position, PathB.transform.position);

		//當距離為0的時候，就代表已經移動到目的地了。
		if (tmp == 0){
			if (isbasic == false) {
				Destroy(gameObject); // 到目的就消失
				firstSpeed = 0f;
			}

		}
	 
	}

}
