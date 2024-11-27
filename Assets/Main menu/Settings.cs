using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using TMPro;

public class Settings : MonoBehaviour
{
    public TMP_Dropdown GraphicsDropdown;
    public Slider SliderMaster, SliderBGM, SliderSFX;
    public AudioMixer Sound;

    public void ChangeGraphicQuality()
    {
        QualitySettings.SetQualityLevel(GraphicsDropdown.value);
    }

    public void ChangeMasterVol()
    {
        Sound.SetFloat("MasterVol", SliderMaster.value);
    }
    public void ChangeBGMVol()
    {
        Sound.SetFloat("BGMVol", SliderBGM.value);
    }
    public void ChangeSFXVol()
    {
        Sound.SetFloat("SFXVol", SliderSFX.value);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
