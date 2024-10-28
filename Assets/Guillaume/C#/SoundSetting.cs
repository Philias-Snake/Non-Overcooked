using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SoundSetting : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer;
    [SerializeField] private Slider BgmSlider;
    [SerializeField] private Slider SfxSlider;

    /*private void Start()
    {
        if (PlayerPrefs.Haskey("bgmVolume"))
        {
            LoadVolume();
        }
        else
        {
            SetBgmVolume();
            //SetSfxVolume();
        }
    }*/

    public void SetBgmVolume()
    {
        float volume = BgmSlider.value;
        audioMixer.SetFloat("bgm", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("bgmVolume", volume);
    }

    private void LoadVolume()
    {
        BgmSlider.value = PlayerPrefs.GetFloat("bgmVolume");

        SetBgmVolume();
    }
}