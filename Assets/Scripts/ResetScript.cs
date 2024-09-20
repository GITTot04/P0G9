using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResetScript : MonoBehaviour
{
    private float timeSinceAction;
    private Image resetCircle;
    private float resetTime = 90f;
    private float delay = 5f;
    private void Start()
    {
        resetCircle = gameObject.transform.GetChild(0).GetComponentInChildren<Image>();
    }
    private void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex != 0)
        {
            timeSinceAction += Time.deltaTime;
            if (Input.anyKeyDown)
            {
                timeSinceAction = 0f;
            }
            resetCircle.fillAmount = (timeSinceAction - delay) / resetTime;
            if (timeSinceAction - delay >= resetTime)
            {
                timeSinceAction = 0f;
                resetCircle.fillAmount = 0f;
                SceneManager.LoadScene(0);
            }
        }
    }
}
