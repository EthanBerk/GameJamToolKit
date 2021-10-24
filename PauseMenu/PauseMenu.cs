using System;
using UnityEngine;
using UnityEngine.Audio;

namespace DefaultNamespace
{
    public class PauseMenu : UnityEngine.MonoBehaviour
    {
        private AudioMixer AudioMixer;

        private void Start()
        {
            AudioMixer.SetFloat("MasterVolume", PlayerPrefs.GetFloat("MasterVolume"));
        }

        public void SetMasterVolume(float volume)
        {
            AudioMixer.SetFloat("MasterVolume", volume);
            PlayerPrefs.SetFloat("MasterVolume", volume);
        }

        public void SetFullScreen()
        {
            Screen.fullScreen = !Screen.fullScreen;
        }
    }
}