using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSceneController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (UnityEngine.Input.GetKeyUp(KeyCode.Mouse0))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("MultipleChoice");
        }
    }
}
