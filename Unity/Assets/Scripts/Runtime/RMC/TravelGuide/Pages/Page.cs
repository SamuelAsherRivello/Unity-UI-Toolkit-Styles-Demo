using RMC.Audio;
using RMC.TravelGuide.Page.UIs;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace RMC.TravelGuide.Pages
{
    /// <summary>
    /// Main entry point for the Scene
    /// </summary>
    public class Page : MonoBehaviour
    {
        //  Properties ------------------------------------

            
        //  Fields ----------------------------------------
        [Header("UI")]
        [SerializeField]
        protected PageUI _pageUI;

        //  Unity Methods ---------------------------------
        
        /// <summary>
        /// Runs once per Scene. Use for initialization
        /// </summary>
        protected virtual void Start()
        {
            //
        }

        
        protected void Update()
        {
            // Click [2] to toggle the theme
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                _pageUI.ToggleTheme();
            }
            
            // Click [3] to reload scene
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                ReloadScene();
            }
            
            // Click [4] to reload game
            if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                ReloadGame();
            }
        }
        
        
        //  Methods ---------------------------------------
        /// <summary>
        /// Restart the same Scene as a #hack to restart the game
        /// </summary>
        private void ReloadScene()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        
        
        /// <summary>
        /// Restart the same Scene as a #hack to restart the game
        /// </summary>
        private void ReloadGame()
        {
            SceneManager.LoadScene(0);
        }
        

        /// <summary>
        /// Play audio using the AudioManager imported via
        /// https://github.com/SamuelAsherRivello/rmc-core/
        /// </summary>
        /// <param name="audioClipName">Must match AudioClip name within
        /// Assets/Settings/Audio/AudioManagerConfiguration.asset</param>
        private void PlayAudioClip(string audioClipName)
        {
            AudioManager.Instance.PlayAudioClip(audioClipName);
        }

        
        //  Event Handlers --------------------------------
    }
}