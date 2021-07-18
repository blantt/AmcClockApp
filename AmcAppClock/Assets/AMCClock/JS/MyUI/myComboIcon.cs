using System.Collections.Generic;
using UIWidgets;
using UIWidgets.Extensions;
using UnityEngine;
using UnityEngine.UI;
using Newtonsoft.Json;
using System.Net;
using System.IO;
using System.Data;

public class myComboIcon : MonoBehaviour
{

    public AutoComboboxIcons myAutoComboboxIcons;

    public enum UiType
    {
        ListViewIcons,
        ListView
    }
    public UiType myType;
    
    private ListViewIcons myListViewIcons;
    private ListView myListView;
    public string m_ApiUrl;
    public string m_Apipara;
    public Text m_SelectValue;
    public Text m_SelectName;
    private ListViewIconsItemDescription ListViewIconDescription;

    

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {




    }
    void Awake()
    {
        //if (m_ApiUrl != "")
        //{
        //    loadDefault(m_ApiUrl, m_Apipara);
        //}


    }

    private void OnGUI()
    {
        //https://godstamps.blogspot.com/2011/04/unity-gui.html
        //GUI.matrix = Matrix4x4.Scale(scale);
        // GUIUtility.ScaleAroundPivot(scale, Vector2.zero);

    }



    public void loadDefault(string strurl, string strpara)
    {
        var tempcombo = new AutoComboboxIcons();
        tempcombo = myAutoComboboxIcons.GetComponent<AutoComboboxIcons>();
        tempcombo.Combobox.ListView.DataSource.Clear();

        DataTable Returnda = new DataTable();
        Returnda = ApiDB.ApiReturnData(strurl);
        AddComboItem("", "");
        foreach (DataRow row in Returnda.Rows)
        {

            string name1 = row["name1"].ToString();
            string name2 = row["name2"].ToString();

            AddComboItem(name1, name2);
        }

    }

    public void AddComboItem(string str1, string str2)
    {
        var new_item = new ListViewIconsItemDescription()
        {
            Name = str1,
            Name2 = str2
        };
        var tempcombo = new AutoComboboxIcons();
        tempcombo = myAutoComboboxIcons.GetComponent<AutoComboboxIcons>();
        tempcombo.Combobox.ListView.DataSource.Add(new_item);
    }


    public void AddComboItems(string ApiUrl, string para)
    {
        var new_item = new ListViewIconsItemDescription()
        {

            Name = "test item",
            Name2 = "test item"
        };
        var new_item2 = new ListViewIconsItemDescription()
        {

            Name = "test item2",
            Name2 = "test item2"
        };
        var new_items = new List<ListViewIconsItemDescription>()
            {
                new_item,
                new_item2
            };
        var tempcombo = new AutoComboboxIcons();
        tempcombo = myAutoComboboxIcons.GetComponent<AutoComboboxIcons>();
        tempcombo.Combobox.Clear();
        tempcombo.Combobox.ListView.DataSource.AddRange(new_items);
    }


    //function OnGUI()
    //{

    //    GUI.matrix = Matrix4x4.Scale(scale);

    //    /* .... 其他GUI ....*/
    //}




    public void SetDataSourceItem2(string ApiUrl, string para)
    {
        if (myType == UiType.ListViewIcons)
        {


            var bb2 = new AutoComboboxIcons();
            bb2 = myAutoComboboxIcons.GetComponent<AutoComboboxIcons>();
            var bb = new ListViewIconsItemDescription();
            bb.Name = "aa";
            bb.Name = "aa2";
            bb.Value = 2;
            bb2.Combobox.ListView.DataSource.Add(ListViewIconDescription);

            bb.Name = "cc";
            bb.Name = "cc2";
            bb.Value = 3;
            bb2.Combobox.ListView.DataSource.Add(ListViewIconDescription);


        }



    }

    public void SetDataSourceItem(string ApiUrl, string para)
    {
        if (myType == UiType.ListViewIcons)
        {

            var bb = new ListViewIconsItemDescription();

            myListViewIcons = myAutoComboboxIcons.GetComponent<ListViewIcons>();

            bb.Name = "aa";
            bb.Name = "aa2";

            myListViewIcons.DataSource.Add(ListViewIconDescription);
             
        }



    }

    public string GetSelectedValue()
    {
        myListViewIcons = myAutoComboboxIcons.GetComponent<ListViewIcons>();
         
        var indices = myListViewIcons.SelectedIndices;

         return myListViewIcons.SelectedItem.Name;

    }


    public void setComboSelectByKey(string key)
    {
        int iselect = -1;
        foreach (ListViewIconsItemDescription item in myAutoComboboxIcons.Combobox.ListView.DataSource)
        {
            iselect += 1;
            var d = item.Name;
            if (d == key)
            {
                break;
            }
        }
        myAutoComboboxIcons.Combobox.ListView.SelectedIndex = iselect;

    }

    private void GetSelected()
    {

        if (myType == UiType.ListViewIcons)
        {

            myListViewIcons = myAutoComboboxIcons.GetComponent<ListViewIcons>();

            // Get selected indices
            var indices = myListViewIcons.SelectedIndices;

            m_SelectValue.text = myListViewIcons.SelectedItem.Name;
            m_SelectName.text = myListViewIcons.SelectedItem.Name2;
            



        }

        if (myType == UiType.ListView)
        {


            myListView = myAutoComboboxIcons.GetComponent<UIWidgets.ListView>();


            // Get selected indices
            var indices = myListView.SelectedIndices;


        }



    }
}
