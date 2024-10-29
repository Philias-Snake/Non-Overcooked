using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SoundSetting : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer;
    [SerializeField] private Slider BgmSlider;
    [SerializeField] private Slider SfxSlider;

    private void Start()
    {
        if (PlayerPrefs.HasKey("bgmVolume"))
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
        float volume = BgmSlider.value;
        audioMixer.SetFloat("bgm", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("bgmVolume", volume);
    }

    public void SetSfxVolume()
    {
        float volume = SfxSlider.value;
        audioMixer.SetFloat("sfx", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("sfxVolume", volume);
    }

    private void LoadVolume()
    {
        BgmSlider.value = PlayerPrefs.GetFloat("bgmVolume");
        SfxSlider.value = PlayerPrefs.GetFloat("sfxVolume");

        SetBgmVolume();
        SetSfxVolume();
    }
}