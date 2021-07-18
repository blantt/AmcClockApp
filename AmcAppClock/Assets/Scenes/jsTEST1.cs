using Doozy.Engine.UI;
using UnityEngine;
using UnityEngine.UI;

public class jsTEST1 : MonoBehaviour
{
    public string aaa;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


     public void tt2()
    {
        string PopupName = "Popup1";
        string Title = "00022";
        string Message = "aa3";
        UIPopup popup = UIPopup.GetPopup(PopupName);

        //make sure that a popup clone was actually created
        if (popup == null)
            return;

        //we assume (because we know) this UIPopup has a Title and a Message text objects referenced, thus we set their values
        popup.Data.SetLabelsTexts(Title, Message);

        //update the hide settings
        popup.HideOnBackButton = true;
        popup.HideOnClickAnywhere = true;
        popup.HideOnClickOverlay = true;
        popup.HideOnClickContainer = true;

        bool HideOnBackButton = true;
        bool HideOnClickAnywhere = true;
        bool HideOnClickOverlay = true;
        bool HideOnClickContainer = true;

        //if the developer did not enable at least one hide option, make the UIPopup automatically hide itself (to avoid blocking the UI)
        if (!HideOnBackButton && !HideOnClickAnywhere && !HideOnClickOverlay && !HideOnClickContainer)
        {
            popup.AutoHideAfterShow = true;
            popup.AutoHideAfterShowDelay = 3f;
          //  DDebug.Log("Popup '" + PopupName + "' is set to auto-hide in " + popup.AutoHideAfterShowDelay + " seconds because you did not enable any hide option");
        }

        popup.Show(); //show the popup


    }
}
