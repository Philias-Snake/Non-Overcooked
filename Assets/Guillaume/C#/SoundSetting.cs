using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SoundSetting : MonoBehaviour
{
    /// <summary>
    /// 
    /// </summary>
    [SerializeField] private AudioMixer audioMixer;
    [SerializeField] private Slider BgmSlider;
    [SerializeField] private Slider SfxSlider;

    /// <summary>
    /// 
    /// </summary>
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

    /// <summary>
    /// 
    /// </summary>
    public void SetBgmVolume()
    {
        float volume = BgmSlider.value;
        audioMixer.SetFloat("bgm", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("bgmVolume", volume);
    }

    /// <summary>
    /// 
    /// </summary>
    public void SetSfxVolume()
    {
        float volume = SfxSlider.value;
        audioMixer.SetFloat("sfx", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("sfxVolume", volume);
    }

    /// <summary>
    /// 
    /// </summary>
    private void LoadVolume()
    {
        BgmSlider.value = PlayerPrefs.GetFloat("bgmVolume");
        SfxSlider.value = PlayerPrefs.GetFloat("sfxVolume");

        SetBgmVolume();
        SetSfxVolume();
    }
}