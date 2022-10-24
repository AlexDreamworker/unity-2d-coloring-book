using UnityEngine;
using UnityEngine.Audio;

namespace ChildPaint.Audio
{
    public class SoundManager : MonoBehaviour
    {
        public static SoundManager Instance;

        [SerializeField] private AudioSource _musicSource, _sfxSource;
        [SerializeField] private AudioMixer mixer;

        private readonly string _mixerSoundVolumeKey = "SoundVolume";
        private readonly string _mixerVoiceVolumeKey = "VoiceVolume";
        private readonly string _prefsSoundVolumeKey = "sound volume";
        private readonly string _prefsVoiceVolumeKey = "voice volume";

        void Awake() 
        {
            if (Instance == null) 
                Instance = this;
        }

        void Start()
        {
            mixer.SetFloat(_mixerSoundVolumeKey, Mathf.Log10(PlayerPrefs.GetFloat(_prefsSoundVolumeKey)) * 20);
            mixer.SetFloat(_mixerVoiceVolumeKey, Mathf.Log10(PlayerPrefs.GetFloat(_prefsVoiceVolumeKey)) * 20);

            _musicSource.Play();
        }

        public void ChangeSoundVolume(float value) 
        {
            mixer.SetFloat(_mixerSoundVolumeKey, Mathf.Log10(value) * 20);
            PlayerPrefs.SetFloat(_prefsSoundVolumeKey, value);
            PlayerPrefs.Save();
        }

        public void ChangeVoiceVolume(float value) 
        {
            mixer.SetFloat(_mixerVoiceVolumeKey, Mathf.Log10(value) * 20);
            PlayerPrefs.SetFloat(_prefsVoiceVolumeKey, value);
            PlayerPrefs.Save();
        }
    }
}

