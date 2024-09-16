using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SliderAnswerText : MonoBehaviour
{
    private void Awake()
    {
        if (PersistantInfoScript.info.sliderFinalValue == 0)
        {
            GameObject.FindGameObjectWithTag("AnswerText").GetComponent<TextMeshProUGUI>().text = "0";
        }
        else if (PersistantInfoScript.info.sliderFinalValue == 1)
        {
            GameObject.FindGameObjectWithTag("AnswerText").GetComponent<TextMeshProUGUI>().text = "1";
        }
        else
        {
            GameObject.FindGameObjectWithTag("AnswerText").GetComponent<TextMeshProUGUI>().text = "2";
        }
    }
}
