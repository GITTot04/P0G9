using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextInitiator : MonoBehaviour
{
   
    private void Awake()
    {
        if (PersistantInfoScript.info.Svar){
           GameObject.FindGameObjectWithTag("Svar1").GetComponent<TextMeshProUGUI>().text = "Det rigtigt";
           
        } else {
            GameObject.FindGameObjectWithTag("Svar1").GetComponent<TextMeshProUGUI>().text = "Det forkert";
        }
       
    }
}