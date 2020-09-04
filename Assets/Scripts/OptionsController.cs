using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour
{
    [SerializeField] Slider VolumeSlider;
    [SerializeField] Slider DifficultySlider;
    // Start is called before the first frame update
    void Start()
    {
        VolumeSlider.value = PlayerPrefsController.GetVolume();
        DifficultySlider.value = PlayerPrefsController.GetDifficulty();
    }

    // Update is called once per frame
    void Update()
    {
        if(FindObjectOfType<MusicController>() != null)
        {
            FindObjectOfType<MusicController>().GetComponent<AudioSource>().volume = VolumeSlider.value;
        }        
    }

    public void ReturnToStartScreen()
    {
        PlayerPrefsController.SetVolume(VolumeSlider.value);
        PlayerPrefsController.SetDifficulty(DifficultySlider.value);
        SceneLoader.StartScreen();
    }
}
