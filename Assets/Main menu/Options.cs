using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using TMPro;

public class Options : MonoBehaviour
{
    public TMP_Dropdown QualityDropdown;
    public Slider SliderMaster, SliderBGM, SliderSFX;
    public AudioMixer Sound;

    public void ChangeQuality()
    {
        QualitySettings.SetQualityLevel(QualityDropdown.value);
    }

    public void ChangeMaster()
    {
        Sound.SetFloat("MasterVol", SliderMaster.value);
    }
    public void ChangeBGM()
    {
        Sound.SetFloat("BGMVol", SliderBGM.value);
    }
    public void ChangeSFX()
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
