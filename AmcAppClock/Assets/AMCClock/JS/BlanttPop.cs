using Doozy.Engine.UI;
using UnityEngine;
using UnityEngine.UI;

namespace Doozy.Examples
{
    public class BlanttPop : MonoBehaviour
    {
        public string PopupName = "Popup1";
        public string Title = "Example Title";
        public string Message = "This is an example message for this UIPopup";
        public UIPopup mypop;
        // Start is called before the first frame update
        void Start()
        {

          

        }

        // Update is called once per frame
        void Update()
        {

        }


        public void ShowPopup2() {
            mypop.Show();
        }

        public void ShowPopup()
        {
            //get a clone of the UIPopup, with the given PopupName, from the UIPopup Database 
            UIPopup popup = UIPopup.GetPopup(PopupName);

            //make sure that a popup clone was actually created
            if (popup == null)
                return;

            //we assume (because we know) this UIPopup has a Title and a Message text objects referenced, thus we set their values
            popup.Data.SetLabelsTexts(Title, Message);

            //update the hide settings
            //popup.HideOnBackButton = HideOnBackButton;
            //popup.HideOnClickAnywhere = HideOnClickAnywhere;
            //popup.HideOnClickOverlay = HideOnClickOverlay;
            //popup.HideOnClickContainer = HideOnClickContainer;

            //if the developer did not enable at least one hide option, make the UIPopup automatically hide itself (to avoid blocking the UI)
            //if (!HideOnBackButton && !HideOnClickAnywhere && !HideOnClickOverlay && !HideOnClickContainer)
            //{
            //    popup.AutoHideAfterShow = true;
            //    popup.AutoHideAfterShowDelay = 3f;
            //    DDebug.Log("Popup '" + PopupName + "' is set to auto-hide in " + popup.AutoHideAfterShowDelay + " seconds because you did not enable any hide option");
            //}
            popup.AutoHideAfterShow = true;
            popup.AutoHideAfterShowDelay = 3f;
            popup.Show(); //show the popup
        }


    }


}
