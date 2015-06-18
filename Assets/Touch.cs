using UnityEngine;
using System.Collections;

public class Touch : MonoBehaviour 
{
    public int dragTouch;
    public bool dragging;
    public bool zooming;

    public float prevDist;
    public float dist;

    void Update()
    {
        foreach(UnityEngine.Touch touch in Input.touches)
        {
            if(Input.touchCount == 2)
            {
                zooming = true;
                dragTouch = -1;
                dist = Vector3.Distance(Input.GetTouch(0).position, Input.GetTouch(1).position);
                gameObject.GetComponent<Camera>().fieldOfView += dist - prevDist;
                prevDist = dist;
            }
            else
            {
                zooming = false;
            }

            if (touch.phase == TouchPhase.Ended && touch.tapCount == 1)
            {
                Ray ray = Camera.main.ScreenPointToRay(touch.position);
                RaycastHit hit;

                if(Physics.Raycast(ray, out hit))
                {
                    hit.collider.GetComponent<CubeShatter>().Shatter();
                }
            }

            if((touch.phase == TouchPhase.Moved || touch.phase == TouchPhase.Stationary) && dragTouch == -1)
            {
                dragTouch = touch.fingerId;
            }

            if(touch.phase == TouchPhase.Ended && touch.fingerId == dragTouch)
            {
                dragTouch = -1;
            }

            if (touch.fingerId == dragTouch && zooming == false)
            {
                transform.Rotate(-touch.deltaPosition);
            }
        }
    }
}
