using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    [SerializeField] private TMP_InputField nameInput;
    [SerializeField] private Slider volumeSlider;
    [SerializeField] private TMP_Dropdown resolution;

    private void Start()
    {
        volumeSlider.value = PlayerPrefs.HasKey("volume") ? PlayerPrefs.GetFloat("volume") : volumeSlider.maxValue;
        PlayerPrefs.SetFloat("volume", volumeSlider.value);
        
        nameInput.text = PlayerPrefs.HasKey("inputName") ? PlayerPrefs.GetString("inputName") : nameInput.text = "";
        PlayerPrefs.SetString("inputName", nameInput.text);
        
        resolution.value = PlayerPrefs.HasKey("resolution") ? PlayerPrefs.GetInt("resolution") : 0;
        PlayerPrefs.SetInt("resolution", resolution.value);
    }

    public void SetVolumen()
    {                            
        PlayerPrefs.SetFloat("volume", volumeSlider.value);
    }

    public void SetName()
    {
        PlayerPrefs.SetString("inputName", nameInput.text);
    }

    public void SetResolution()
    {
        PlayerPrefs.SetInt("resolution", resolution.value);
    }

    public void ResetDefault()
    {
        PlayerPrefs.DeleteAll();
        volumeSlider.value = volumeSlider.maxValue;
        PlayerPrefs.SetFloat("volume", volumeSlider.value);
        nameInput.text = "";
        PlayerPrefs.SetString("inputName", nameInput.text);
        resolution.value = 0;
        PlayerPrefs.SetInt("resolution", resolution.value);
    }
}
