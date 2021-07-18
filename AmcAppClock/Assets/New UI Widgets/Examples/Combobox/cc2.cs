using System.Collections.Generic;
using UIWidgets;
using UIWidgets.Extensions;
using UnityEngine;
using UnityEngine.UI;
public class cc2 : MonoBehaviour
{

    public enum UiType
    {
        ListViewIcons,
        ListView
    }
    public UiType myType;
   
    public int getvalue;
    public string gettext;
    public string gettext2;
    private ListViewIcons myListViewIcons;
    private ListView myListView;
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        



    }

    public void GetSelected() {

        if (myType == UiType.ListViewIcons) {

            myListViewIcons = gameObject.GetComponent<ListViewIcons>();
 
            // Get selected indices
            var indices = myListViewIcons.SelectedIndices;
            
            gettext = myListViewIcons.SelectedItem.Name;
            gettext2 = myListViewIcons.SelectedItem.Name2;
            getvalue = myListViewIcons.SelectedItem.Value;
            

        }

        if (myType == UiType.ListView)
        {


            myListView = gameObject.GetComponent<UIWidgets.ListView>();
           
           
            // Get selected indices
            var indices = myListView.SelectedIndices;
           

        }



    }


}
