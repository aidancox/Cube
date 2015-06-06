using UnityEngine;
using System.Collections;

public class CubeControl : MonoBehaviour 
{
    public Vector3 prevPos;
    public Vector3 curPos;
    public Vector3 posDif;
    public float gravity;
    public float sensitivity;    

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
           prevPos = Input.mousePosition * sensitivity;
        }

        if (Input.GetMouseButton(0))
        {
            curPos = Input.mousePosition * sensitivity;
            posDif = prevPos - curPos;
            prevPos = curPos;
        }

        transform.Rotate(posDif);

        if(posDif.x < 0)
        {
            posDif.x += gravity;

            if(posDif.x > -0.1f)
            {
                posDif.x = 0;
            }
        }

		if(posDif.x > 0)
        {
            posDif.x -= gravity;

            if (posDif.x < 0.1f)
            {
                posDif.x = 0;
            }
        }

        if (posDif.y < 0)
        {
            posDif.y += gravity;

            if (posDif.y > -0.1f)
            {
                posDif.y = 0;
            }
        }

        if(posDif.y > 0)
        {
            posDif.y -= gravity;

            if (posDif.y < 0.1f)
            {
                posDif.y = 0;
            }
        }
    }
}