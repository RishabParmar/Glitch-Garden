using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LoseCollider : MonoBehaviour
{
    [SerializeField] AudioClip loseGame;
    int lives = 0;
    TextMeshProUGUI livesText;
    bool lostOnce = false;
    private void Start()
    {
        SetLivesFromDifficultyPlayerPrefs();
        livesText = GameObject.Find("Lives").GetComponent<TextMeshProUGUI>();
        livesText.text = lives.ToString();       
    }

    private void SetLivesFromDifficultyPlayerPrefs()
    {
        // Setting the lives to according to the player difficulty, 5 lives if difficulty set to less than 0.5 and 3 lives if
        // more difficulty
        lives = PlayerPrefsController.GetDifficulty() <= 0.5 ? 5 : 3;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        lives--;
        if(lives >= 0)
        {
            livesText.text = lives.ToString();
            Destroy(collision.gameObject);
        }
        else if(lives < 0 && !lostOnce)
        {
            lostOnce = true;
            GameObject.Find("Game Music Player").GetComponent<AudioSource>().clip = loseGame;
            GameObject.Find("Game Music Player").GetComponent<AudioSource>().Play();
            FindObjectOfType<SceneLoader>().GameOverScene();
        }
    }
}
