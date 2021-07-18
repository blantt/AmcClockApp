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

public class myDateTime : MonoBehaviour
{

    [SerializeField]
    protected DateTimePicker PickerTemplate;

    private DateTime currentValue=DateTime.Now;

    public Text OrinText;
    public UIPopup mypop;

    public string m_YYYYMMDD;
    public string m_時;
    public string m_分;
    public   string m_selecvalue;



    public void open1()
    {
        var picker = PickerTemplate.Clone();
        if (mypop != null) {
            mypop.Show();
        }
      
        picker.Show(currentValue, ValueSelected, Canceled);

         

    }

    // Start is called before the first frame update
    void Start()
    {

        //PickerTemplate = gameObject;
        var d = "";

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void DefaultDate(DateTime d) {

        currentValue = d;

    }




    void ValueSelected(DateTime value)
    {
        currentValue = value;
        //m_selectDate.text = value.ToString();
        //m_select時.text = value.ToString("hh");
        //m_select分.text = value.ToString("mm");

        m_YYYYMMDD= value.ToString();
        m_時 = value.ToString("hh");
        m_分 = value.ToString("mm");
        m_selecvalue = value.ToString("yyyy/MM/dd HH:mm");

        if (OrinText != null) {
            OrinText.text = m_selecvalue;

        }
        if (mypop != null)
        {
            mypop.Hide();
        }
      
    }

    void Canceled()
    {
        if (mypop != null)
        {
            mypop.Hide();
        }
        Debug.Log("canceled");
    }

    
     

}
