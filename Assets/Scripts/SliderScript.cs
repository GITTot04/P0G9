using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SliderScript : MonoBehaviour
{
    private void Start()
    {
        TranslateValue();
    }
    public void TranslateValue()
    {
        if (gameObject.GetComponent<Slider>().value <= 0.33f)
        {
            PersistantInfoScript.info.sliderFinalValue = 0;
        }
        else if (gameObject.GetComponent<Slider>().value <= 0.66f)
        {
            PersistantInfoScript.info.sliderFinalValue = 1;
        }
        else
        {
            PersistantInfoScript.info.sliderFinalValue = 2;
        }
    }
}
