using UnityEngine;
using UnityEngine.UIElements;

namespace RMC.TravelGuide
{
    public class ThemeManager
    {
        private UIDocument _uiDocument;
        private StyleSheet _lightStyleSheet;
        private StyleSheet _darkStyleSheet;
        private bool _isDark = true;

        /// <summary>
        /// Property to get or set the current theme. Defaults to Dark.
        /// Setting this property toggles between Light and Dark themes.
        /// </summary>
        public bool IsDark
        {
            get => _isDark;
            set
            {
                if (_isDark != value)
                {
                    _isDark = value;
                    ApplyTheme();
                }
            }
        }

        /// <summary>
        /// Constructor for ThemeManager. Initializes the theme to Dark.
        /// </summary>
        /// <param name="uiDocument">Reference to the UIDocument.</param>
        /// <param name="lightStyleSheet">Styles specific to the Light theme.</param>
        /// <param name="darkStyleSheet">Styles specific to the Dark theme.</param>
        public ThemeManager(UIDocument uiDocument, StyleSheet lightStyleSheet, StyleSheet darkStyleSheet)
        {
            _uiDocument = uiDocument;
            _lightStyleSheet = lightStyleSheet;
            _darkStyleSheet = darkStyleSheet;

            // Initialize with the dark theme
            ApplyDarkTheme();
        }

        /// <summary>
        /// Applies the current theme based on the value of IsDark.
        /// </summary>
        private void ApplyTheme()
        {
            if (_isDark)
            {
                ApplyDarkTheme();
            }
            else
            {
                ApplyLightTheme();
            }
        }

        /// <summary>
        /// Applies the Light theme.
        /// </summary>
        private void ApplyLightTheme()
        {
            if (_darkStyleSheet != null)
            {
                _uiDocument.rootVisualElement.styleSheets.Remove(_darkStyleSheet);
            }

            if (_lightStyleSheet != null && !_uiDocument.rootVisualElement.styleSheets.Contains(_lightStyleSheet))
            {
                _uiDocument.rootVisualElement.styleSheets.Add(_lightStyleSheet);
            }
        }

        /// <summary>
        /// Applies the Dark theme.
        /// </summary>
        private void ApplyDarkTheme()
        {
            if (_lightStyleSheet != null)
            {
                _uiDocument.rootVisualElement.styleSheets.Remove(_lightStyleSheet);
            }

            if (_darkStyleSheet != null && !_uiDocument.rootVisualElement.styleSheets.Contains(_darkStyleSheet))
            {
                _uiDocument.rootVisualElement.styleSheets.Add(_darkStyleSheet);
            }
        }
    }

}
	