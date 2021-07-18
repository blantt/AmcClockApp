using System.Collections.Generic;
using UIWidgets;
using UIWidgets.Extensions;
using UnityEngine;
using UnityEngine.UI;


public class CanvasBegin : MonoBehaviour
{
    
    // Start is called before the first frame update
    private float baseW=1080;
    private float baseH=1920;
    //private Vector3 scale;
    //private Vector2 scale2;
    //public Text message;
    //private Vector2 scale3 = new Vector2(1, 1);
    //private Vector2 pivotPoint;
    // Start is called before the first frame update
    void Start()
    {
        //Vector2 resolution = transform.root.GetComponent<CanvasScaler>().referenceResolution;
        //RectTransform rect = GetComponent<RectTransform>();
        //float ratio = (Screen.width * resolution.y) / (Screen.height * resolution.x);
        //Debug.Log(ratio);
        //rect.sizeDelta *= ratio;
    }

    // Update is called once per frame
    void Update()
    {




    }
    void Awake()
    {




        CanvasScaler canvasScaler = GetComponent<CanvasScaler>();

        float screenWidthScale = Screen.width / canvasScaler.referenceResolution.x;
        float screenHeightScale = Screen.height / canvasScaler.referenceResolution.y;

        //message.text += "//Screen.width:" + Screen.width;
        //message.text += "//Screen.height:" + Screen.height;
        //message.text += "//canvasScalerx:" + canvasScaler.referenceResolution.x;
        //message.text += "//canvasScalery:" + canvasScaler.referenceResolution.y;
        //message.text += "//screenWidthScale:" + screenWidthScale;
        //message.text += "//screenHeightScale:" + screenHeightScale;

 
         canvasScaler.matchWidthOrHeight = screenWidthScale > screenHeightScale ? 1 : 0;
        // scale = new Vector3((float)(Screen.width) / baseW, (float)(Screen.height) / baseH, 1);

        //https://godstamps.blogspot.com/2011/04/unity-gui.html
        // scale = new Vector3((float)0.5, (float)0.5, 1);
      //  scale2 = new Vector2((float)0.5, (float)0.5 );

    }

    private void OnGUI()
    {
        //https://godstamps.blogspot.com/2011/04/unity-gui.html
        // GUI.matrix = Matrix4x4.Scale(scale);
        // GUIUtility.ScaleAroundPivot(scale2, Vector2.zero);
         
    

    }


}
