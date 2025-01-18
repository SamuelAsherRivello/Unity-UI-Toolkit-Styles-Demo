using UnityEngine;
using UnityEngine.UIElements;

namespace RMC.TravelGuide.Page.UIs
{
    /// <summary>
    /// Renders the UI for the <see cref="Page"/>
    /// </summary>
    public class PageUI : MonoBehaviour
    {
        //  Properties ------------------------------------
        protected UIDocument UIDocument { get { return _uiDocument; }}
        
        //  Fields ----------------------------------------
        [Header("Layout")]
        [SerializeField]
        private UIDocument _uiDocument;

        [Header("Styles")]
        [SerializeField]
        private StyleSheet _lightStyleSheet;

        [SerializeField]
        private StyleSheet _darkStyleSheet;

        private ThemeManager _themeManager;
        
        //  Unity Methods ---------------------------------
        protected virtual void Start()
        {
            Debug.Log($"{GetType().Name}.Start()");
            
            // Initialize the ThemeManager
            _themeManager = new ThemeManager(_uiDocument, _lightStyleSheet, _darkStyleSheet);

            // Example: Toggle theme after 3 seconds
            Invoke(nameof(ToggleTheme), 2f);
        }

        
        //  Methods ---------------------------------------
        private void ToggleTheme()
        {
            _themeManager.IsDark = !_themeManager.IsDark;
            
            //Debug.Log($"ThemeManager.IsDark = {_themeManager.IsDark}");
            
            Invoke(nameof(ToggleTheme), 2f);
        }

        
        //  Event Handlers --------------------------------
    }
}