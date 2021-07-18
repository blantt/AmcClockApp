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

public class js1 : MonoBehaviour
{

    
    [SerializeField]
    protected DateTimePicker PickerTemplate;

    private DateTime currentValue;

    public void open1(){
        var picker = PickerTemplate.Clone();

        picker.Show(currentValue,ValueSelected, Canceled) ;    
        
    }

    // Start is called before the first frame update
    void Start()
    {



        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void ValueSelected(DateTime value)
    {
        currentValue = value;
        Debug.Log("value: " + value);
        var dd = "";
        dd = "aaaa";


    }

    void Canceled()
    {
        Debug.Log("canceled");
    }

}
