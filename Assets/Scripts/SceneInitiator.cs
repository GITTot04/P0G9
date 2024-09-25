using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SceneInitiator : MonoBehaviour
{
    private void Awake()
    {
        if (PersistantInfoScript.info.answerinformation)
        {
        gameObject.GetComponent<TextMeshProUGUI>().text = "Sejt! På medialogi uddannelsen hos AAU kan du netop få lov til at prøve dette, samtidig med en masse andre spændene ting!";
        } 
        else
        {
            gameObject.GetComponent<TextMeshProUGUI>().text = "Helt fair, på medialogi uddannelsen hos AAU kan du heldigvis prøve kræfter med mange andre spændene ting såsom design, VR eller AI";
        }
    }
}
