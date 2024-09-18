using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetScript : MonoBehaviour
{
    float timeSinceAction;
    void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex != 0)
        {
            timeSinceAction += Time.deltaTime;
            if (Input.anyKeyDown)
            {
                timeSinceAction = 0f;
            }
            if (timeSinceAction >= 90f)
            {
                timeSinceAction = 0f;
                SceneManager.LoadScene(0);
            }
        }
    }
}
