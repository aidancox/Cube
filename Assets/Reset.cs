using UnityEngine;
using System.Collections;

public class Reset : MonoBehaviour
{
    public bool reverse;

    void Update()
    {
        foreach (UnityEngine.Touch touch in Input.touches)
        {
            if (touch.tapCount == 2)
            {
                reverse = true;
            }
        }
    }
}
