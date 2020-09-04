using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    private void Start()
    {
        // Run the following method only for splash screen to start screen movement
        LoadNextSceneAfterDelay();
    }

    public void LoadNextScene()
    {
        StartCoroutine(LoadAfterDelay());
    }

    private IEnumerator LoadAfterDelay()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void LoadNextSceneAfterDelay()
    {
        if(SceneManager.GetActiveScene().buildIndex ==0)
        {
            StartCoroutine(LoadingNextScene(SceneManager.GetActiveScene().buildIndex));
        }
    }

    private IEnumerator LoadingNextScene(int currentSceneId)
    {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene(currentSceneId + 1);
    }

    public void GameOverScene()
    {
        StartCoroutine(LoadStartScreen());
    }   

    private IEnumerator LoadStartScreen()
    {        
        yield return new WaitForSeconds(3);        
        SceneManager.LoadScene("Start Screen");
    }

    public static void StartScreen()
    {        
        SceneManager.LoadScene("Start Screen");
    }

    public void OptionsScreen()
    {
        SceneManager.LoadScene("Options Screen");
    }

    public void quitGame()
    {
        Application.Quit();
    }

}
