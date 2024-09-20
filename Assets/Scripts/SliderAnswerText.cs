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
            gameObject.GetComponent<TextMeshProUGUI>().text = "Det er helt ok! \nDet kræver hverken de store matematiske evner eller mat A, for at komme ind på Medialogi!";
        }
        else if (PersistantInfoScript.info.sliderFinalValue == 1)
        {
            gameObject.GetComponent<TextMeshProUGUI>().text = "Nice! \nDu ville sagtens kunne passe ind på Medialogi, da man ikke behøver mat A!";
        }
        else
        {
            gameObject.GetComponent<TextMeshProUGUI>().text = "Sådan! \nMedialogi kræver ikke mat A, men du kommer til at kunne bruge dine matematiske evner i kodning eller lignende!";
        }
    }
}
