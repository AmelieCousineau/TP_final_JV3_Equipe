using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class VolumeSettings : MonoBehaviour
{
    [SerializeField] AudioMixer mixer;
    [SerializeField] Slider musicSlider;

    const string MIXER_MUSIC = "VolumeMusic";

    void Awake(){
        musicSlider.onValueChanged.AddListener(SetMusicVolume);
    }

    void SetMusicVolume(float value){
        mixer.SetFloat(MIXER_MUSIC, Mathf.Log10(value) * 20);
    }
}
