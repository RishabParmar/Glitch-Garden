using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LoseCollider : MonoBehaviour
{
    [SerializeField] AudioClip loseGame;
    int lives = 5;
    TextMeshProUGUI livesText;    
    private void Start()
    {        
        livesText = GameObject.Find("Lives").GetComponent<TextMeshProUGUI>();
        livesText.text = lives.ToString();       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        lives--;
        if(lives >= 0)
        {
            livesText.text = lives.ToString();
            Destroy(collision.gameObject);
        }
        if(lives <= 0)
        {                      
            GameObject.Find("Game Music Player").GetComponent<AudioSource>().clip = loseGame;
            GameObject.Find("Game Music Player").GetComponent<AudioSource>().Play();
            FindObjectOfType<SceneLoader>().GameOverScene();
        }
    }
}
