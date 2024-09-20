using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnswerController : MonoBehaviour
{
    public GameObject mainCanvas;
    public GameObject answerCanvas;

    public void AnswerButtonClicked(int buttonID)
    {
        switch (buttonID)
        {
            case 0:
                SetAnswerScreen("Du Svarede Kommunikation", "En god del af Medialogi er at kommunikere dig, båede internt og externt. Med de færdigheder i kommunikation du får kan du arbejde som project manager og meget mere :D.");
                break;
            case 1:
                SetAnswerScreen("Du Svarede IT og Technologi", "På Medialogi arbejder du med meget inde for IT. Du får færdigheder i kodning og brug af medier som kan give adgang til jobs som software developer, game developer of meget mere :D");
                break;
            case 2:
                SetAnswerScreen("Du Svarede Design", "");
                break;
            case 3:
                SetAnswerScreen("Du Svarede Kreativitet", "");
                break;
            case 4:
                SetAnswerScreen("Du Svarede Mennesker", "");
                break;
        }
    }

    public void SetAnswerScreen(string answerScreenTitle, string answerScreenBody)
    {
        
        mainCanvas.SetActive(false);
        answerCanvas.SetActive(true);
        TMP_Text[] Text = answerCanvas.GetComponentsInChildren<TMP_Text>();
        Text[0].text = answerScreenTitle;
        Text[1].text = answerScreenBody;
    }
    public void nextScene()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void Update()
    {
        if (answerCanvas.activeSelf && Input.GetMouseButtonDown(0)) {
            nextScene();
        }   
    }
}
