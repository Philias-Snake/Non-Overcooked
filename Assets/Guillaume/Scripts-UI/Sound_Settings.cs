using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Sound_Settings : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer;
    [SerializeField] private Slider BGMSlider;
    [SerializeField] private Slider SFXSlider;

    void Start()
    {
        if (PlayerPrefs.HasKey("musicVolume"))
        {
            LoadVolume();
        }
        else
        {
            SetBgmVolume();
            SetSfxVolume();
        }
    }

    public void SetBgmVolume()
    {
        float volume = BGMSlider.value;
        audioMixer.SetFloat("bgm", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("bgmVolume", volume);
    }

    public void SetSfxVolume()
    {
        float volume = SFXSlider.value;
        audioMixer.SetFloat("sfx", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("sfxVolume", volume);
    }

    public void LoadVolume()
    {
        BGMSlider.value = PlayerPrefs.GetFloat("musicVolume");
        SFXSlider.value = PlayerPrefs.GetFloat("sfxVolume");

        SetBgmVolume();
        SetSfxVolume();
    }
}