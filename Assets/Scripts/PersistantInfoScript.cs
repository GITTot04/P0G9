using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistantInfoScript : MonoBehaviour
{
    public static PersistantInfoScript info;
    public bool answerinformation;

    public int sliderFinalValue;
    private void Awake()
    {
        info = this;
        DontDestroyOnLoad(gameObject);
    }
}
