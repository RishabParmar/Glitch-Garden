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
}
