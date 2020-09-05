using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameTimerSlider : MonoBehaviour
{
    [SerializeField] float LevelTime = 10f;
    [SerializeField] AudioClip winGame;
    bool callJustOnce = true;
    GameObject levelStatus;

    private void Start()
    {
        // A disabled gameObject cannot be found using Find() or any other search way. For this to happen, you have 
        // to store the gameobject reference, then disable it and enable it using the stored reference if you wish to
        levelStatus = GameObject.Find("Level Status");
        levelStatus.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Slider>().value = Time.timeSinceLevelLoad / LevelTime;

        bool timeFinished = (Time.timeSinceLevelLoad >= LevelTime);
        if(timeFinished)
        {
            FindObjectOfType<EnemySpawner>().StopEnemySpawning();
            if(ComputeEnemyCountInScene() <= 0 && callJustOnce)
            {
                LoadNextLevelAfterWinning();
                callJustOnce = false;
            }
        }
    }

    private int ComputeEnemyCountInScene()
    {
        return FindObjectsOfType<Attacker>().Length;
    }

    private void LoadNextLevelAfterWinning()
    {
        levelStatus.SetActive(true);
        GameObject.Find("Game Music Player").GetComponent<AudioSource>().clip = winGame;
        GameObject.Find("Game Music Player").GetComponent<AudioSource>().Play();
        FindObjectOfType<SceneLoader>().GameOverScene();       
    }
}
