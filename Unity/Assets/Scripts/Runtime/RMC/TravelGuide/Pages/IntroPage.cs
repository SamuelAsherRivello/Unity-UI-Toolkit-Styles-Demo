using RMC.Audio;
using RMC.TravelGuide.Page.UIs;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace RMC.TravelGuide.Pages
{
    /// <summary>
    /// Main entry point for the Scene
    /// </summary>
    public class IntroPage : Page
    {
        //  Properties ------------------------------------
        public PageUI PageUI { get { return _pageUI; } }

        
        //  Fields ----------------------------------------

        
        //  Unity Methods ---------------------------------
        
        /// <summary>
        /// Runs once per Scene. Use for initialization
        /// </summary>
        protected override void Start()
        {
            base.Start();
            Debug.Log($"{GetType().Name}.Start()");
        }

        
        //  Methods ---------------------------------------
        /// <summary>
        /// Restart the same Scene as a #hack to restart the game
        /// </summary>
        private void ReloadGame()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        

        /// <summary>
        /// Play system using the AudioManager imported via https://github.com/SamuelAsherRivello/rmc-core/
        /// </summary>
        /// <param name="audioClipName">Must match AudioClip name within Assets/Settings/Audio/AudioManagerConfiguration.asset</param>
        private void PlayAudioClip(string audioClipName)
        {
            AudioManager.Instance.PlayAudioClip(audioClipName);
        }

        //  Event Handlers --------------------------------
    }
}