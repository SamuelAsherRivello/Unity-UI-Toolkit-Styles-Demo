using RMC.TravelGuide.Page.UIs;
using UnityEngine;
using UnityEngine.UIElements;

namespace RMC.TravelGuide.Pages
{
    /// <summary>
    /// Main entry point for the Scene
    ///
    /// See view at <see cref="ListingPage"/>
    /// 
    /// </summary>
    public class ListingPage : Page
    {
        //  Properties ------------------------------------
        private ListingPageUI ListingPageUI { get { return _pageUI as ListingPageUI; } }

            
        //  Fields ----------------------------------------

        
        //  Unity Methods ---------------------------------
        protected override void Start()
        {
            base.Start();
            Debug.Log($"{GetType().Name}.Start()");
            
            ListingPageUI.NextPageButton.RegisterCallback<ClickEvent>(NextPageButton_OnClickEvent);
            ListingPageUI.NextSectionButton.RegisterCallback<ClickEvent>(NextSectionButton_OnClickEvent);
        }
        
        
        protected override void OnDestroy()
        {
            ListingPageUI?.NextPageButton?.UnregisterCallback<ClickEvent>(NextPageButton_OnClickEvent);
            ListingPageUI?.NextSectionButton?.UnregisterCallback<ClickEvent>(NextSectionButton_OnClickEvent);
            base.OnDestroy();
        }

        
        //  Methods ---------------------------------------

        
        //  Event Handlers --------------------------------
        private void NextSectionButton_OnClickEvent(ClickEvent evt)
        {
            Debug.Log("TODO: NextSectionButton_OnClickEvent() ");
        }
        
        private void NextPageButton_OnClickEvent(ClickEvent evt)
        {
            LoadNextScene();
        }
    }
}