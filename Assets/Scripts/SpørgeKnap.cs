using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SpørgeKnap : MonoBehaviour
{
    public bool buttonID;
    public void SwapScene(int sceneIndex)
    {
        PersistantInfoScript.info.Svar = buttonID;
        SceneManager.LoadScene(sceneIndex);
    }
}
