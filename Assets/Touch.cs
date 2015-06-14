using UnityEngine;
using System.Collections;

public class Touch : MonoBehaviour 
{
    public int dragTouch;

    void Update()
    {
        foreach(UnityEngine.Touch touch in Input.touches)
        {
            if (touch.phase == TouchPhase.Ended && touch.tapCount == 1)
            {
                Ray ray = Camera.main.ScreenPointToRay(touch.position);
                RaycastHit hit;

                if(Physics.Raycast(ray, out hit))
                {
                    hit.collider.GetComponent<CubeShatter>().Shatter();
                }
            }

            if(touch.phase == TouchPhase.Moved || touch.phase == TouchPhase.Stationary && dragTouch == -1)
            {
                dragTouch = touch.fingerId;
            }

            if(touch.fingerId == dragTouch)
            {
                transform.Rotate(touch.deltaPosition);
            }
        }
    }
}
