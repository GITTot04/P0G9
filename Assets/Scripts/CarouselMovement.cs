using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class CarouselMovement : MonoBehaviour {
    public ScrollRect scrollRect;
    public float scrollTime; 
    private float[] positions; 
    private int currentPage = 0;

    void Start() {
        positions = new float[2];
        positions[0] = 0f;
        positions[1] = 1f;

    StartCoroutine(AutoScrollCoroutine());
    }

      IEnumerator SmoothScrollToPosition(float targetPosition) //smooth scroll, takes the updated position of currentPage as input element
    {
        float duration = 0.5f;  // Duration of the smooth scrolling
        float time = 0f;
        float start = scrollRect.horizontalNormalizedPosition; // stores the initial horizontal position

        while (time < duration) // starts while loop that runs as long as time is less than duration
        {
            time += Time.deltaTime; // increments the time by delta, which makes the smooth transition independent of framrate count
            scrollRect.horizontalNormalizedPosition = Mathf.Lerp(start, targetPosition, time / duration); // the new horizontal position is updated and set to a function mathf, taking start, new target position and time divided with duration to make a smooth transition from the current index to the next
            yield return null; // yields and returns null, makes the scroll position make a per-frame update
        }

        scrollRect.horizontalNormalizedPosition = targetPosition; // in case the image doesnt line up perfectley, this sets the precise horisziontal position to the updated position of CurrentPage
    }

    IEnumerator AutoScrollCoroutine() {
        while(true) {
            yield return new WaitForSeconds(scrollTime); // wait for the timer to count

            currentPage = (currentPage + 1) % positions.Length; //update current page and wrap around when length is met

            StartCoroutine(SmoothScrollToPosition(positions[currentPage])); // startCouroutine with smooth scroll to position for the updates page
        }
    }
}
