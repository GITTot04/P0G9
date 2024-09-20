using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneLoader : MonoBehaviour
{
    public void SwapScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
    public void SwapScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
