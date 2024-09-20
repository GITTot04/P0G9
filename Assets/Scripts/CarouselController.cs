using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarouselController : MonoBehaviour
{
    float duration = 2f;
    float delay = 10f;
    float timeSinceLastSwap;
    bool swapReady = false;
    Vector2 startPos;
    Vector2 endPos;
    float timeSpentSwappingImage;
    void Update()
    {
        if (!swapReady)
        {
            timeSinceLastSwap += Time.deltaTime;
        }
        if (timeSinceLastSwap >= delay)
        {
            GetSwapDetails();
            swapReady = true;
            timeSinceLastSwap = 0;
        }
        if (gameObject.GetComponent<RectTransform>().anchoredPosition != endPos && swapReady == true)
        {
            timeSpentSwappingImage += Time.deltaTime;
            gameObject.GetComponent<RectTransform>().anchoredPosition = Vector2.Lerp(startPos, endPos, timeSpentSwappingImage / duration);
        }
        if (gameObject.GetComponent<RectTransform>().anchoredPosition == endPos && swapReady == true)
        {
            swapReady = false;
            timeSpentSwappingImage = 0f;
        }
    }
    private void GetSwapDetails()
    {
        startPos = gameObject.GetComponent<RectTransform>().anchoredPosition;
        if (startPos == new Vector2(0, 0))
        {
            endPos = new Vector2(-1000, 0);
        }
        else
        {
            endPos = new Vector2(0, 0);
        }
    }
}
