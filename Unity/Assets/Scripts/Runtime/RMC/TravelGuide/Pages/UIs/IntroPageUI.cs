using UnityEngine;
using UnityEngine.UIElements;

namespace RMC.TravelGuide.Page.UIs
{
    /// <summary>
    /// Renders the UI for the <see cref="Page"/>
    /// </summary>
    public class IntroPageUI : PageUI
    {
        //  Properties ------------------------------------
        public Button NextSectionButton { get { return UIDocument?.rootVisualElement.Q<Button>("NextSectionButton"); }}
        public Button NextPageButton { get { return UIDocument?.rootVisualElement.Q<Button>("NextPageButton"); }}
        
        
        //  Fields ----------------------------------------


        //  Unity Methods ---------------------------------
        protected override void Start()
        {
            base.Start();
            Debug.Log($"{GetType().Name}.Start()");
        }

        
        //  Methods ---------------------------------------

        
        //  Event Handlers --------------------------------
    }
}