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
        protected void Start()
        {
            Debug.Log($"{GetType().Name}.Start()");
        }

        /// <summary>
        /// Runs every frame. Use for input/physics/gameplay
        /// </summary>
        protected void Update()
        {
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