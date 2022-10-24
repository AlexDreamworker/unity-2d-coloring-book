using UnityEngine;
using UnityEngine.UI;

namespace ChildPaint.Audio
{
    public class VolumeSlider : MonoBehaviour
    {
        public string getPrefsName;

        private Slider _slider;
        private readonly string _prefsSoundVolumeKey = "sound volume";
        private readonly string _prefsVoiceVolumeKey = "voice volume";

        void Start()
        {
            _slider = GetComponent<Slider>();

            _slider.value = PlayerPrefs.GetFloat(getPrefsName, 1);

            if (getPrefsName == _prefsSoundVolumeKey)
                _slider.onValueChanged.AddListener(val => SoundManager.Instance.ChangeSoundVolume(val));
            else if (getPrefsName == _prefsVoiceVolumeKey) 
                _slider.onValueChanged.AddListener(val => SoundManager.Instance.ChangeVoiceVolume(val));           
        }
    }
}

