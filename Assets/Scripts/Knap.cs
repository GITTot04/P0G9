using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Knap : MonoBehaviour
{
    public bool answer;
     public void SwapScene(int sceneIndex)
    {
        PersistantInfoScript.info.answerinformation = answer;
        SceneManager.LoadScene(sceneIndex);
    }

}
