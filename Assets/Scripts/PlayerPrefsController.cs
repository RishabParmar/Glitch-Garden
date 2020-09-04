using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsController : MonoBehaviour
{
    const string VOLUME_KEY = "volume";
    const string DIFFICULTY_KEY = "difficulty";
    public static void SetVolume(float volume)
    {
        if(volume >= 0.0f && volume <= 1.0)
        {            
            PlayerPrefs.SetFloat(VOLUME_KEY, volume);
        } else
        {
            Debug.LogError("Volume out of preffered bounds");
        }
    }

    public static float GetVolume()
    {
        return PlayerPrefs.GetFloat(VOLUME_KEY);
    }

    public static void SetDifficulty(float difficulty)
    {
        if (difficulty >= 0.0f && difficulty <= 1.0)
        {           
            PlayerPrefs.SetFloat(DIFFICULTY_KEY, difficulty);
        }
        else
        {
            Debug.LogError("Difficulty out of preffered bounds");
        }
    }

    public static float GetDifficulty()
    {
        return PlayerPrefs.GetFloat(DIFFICULTY_KEY);
    }
}
