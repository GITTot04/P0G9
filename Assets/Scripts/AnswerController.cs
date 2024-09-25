using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
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
                SetAnswerScreen("Du Svarede Kommunikation", "Kommuniaktion er en vigtig del af Medialogi, både internt og externt. Med de færdigheder i kommunikation du får, kan du arbejde som project manager og meget mere.");
                break;
            case 1:
                SetAnswerScreen("Du Svarede IT og Technologi", "På Medialogi arbejder du meget med IT. Du får færdigheder i kodning og brug af medier, som kan give adgang til jobs som software developer, game developer og meget mere.");
                break;
            case 2:
                SetAnswerScreen("Du Svarede Design", "Som Medialogistuderende kommer du til at arbejde med grafisk design. Du vil for eksempel lære at lave brugervenlige interfaces.");
                break;
            case 3:
                SetAnswerScreen("Du Svarede Kreativitet", "Kreativitet er en stor del af medialogi, da man i mange af sine projekter selv skal finde på sine ideer.");
                break;
            case 4:
                SetAnswerScreen("Du Svarede Mennesker", "I Medialogi vil du komme til at arbejde med projekter, der kan være meget menneskenære. Du vil lære at lave programmer, som kan hjælpe folk i den virkelige verden.");
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
}
