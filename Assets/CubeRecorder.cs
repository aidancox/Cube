using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CubeRecorder : MonoBehaviour 
{
    List<Vector3> positions = new List<Vector3>();
    List<Quaternion> rotations = new List<Quaternion>();
    public int index;
    public int splitIndex;
    public bool reverse;


    void Start()
    {
        reverse = false;
    }

    void Update()
    {
        if(reverse == false)
        {
            positions.Add(transform.position);
            rotations.Add(transform.rotation);
        }
        else
        {
            transform.position = positions[index];
            transform.rotation = rotations[index];
            index -= 3;

            if(index <= splitIndex)
            {
                gameObject.GetComponent<Collider>().enabled = true;
                gameObject.GetComponent<Renderer>().enabled = true;
            }

            if (index <= 0)
            {
                if (transform.localScale == new Vector3(1,1,1))
                {
                    reverse = false;
                    positions = new List<Vector3>();
                    rotations = new List<Quaternion>();
                    index = 0;
                    splitIndex = 0;
                    GetComponent<Rigidbody>().isKinematic = false;
                    GetComponent<Reset>().reverse = false;
                }
                else
                {
                    Destroy(gameObject);
                }
            }
        }

        if(GetComponent<Reset>().reverse == true && reverse == false && positions.Count > 0)
        {
            if (transform.localScale.x == 1 && GetComponent<Collider>().enabled == true)
            {
                GetComponent<Reset>().reverse = false;
            }
            else
            {
                index = positions.Count - 1;
                reverse = true;
            }
        }

        if(GetComponent<Collider>().enabled == false && splitIndex == 0)
        {
            splitIndex = positions.Count - 1;
        }
    }
}
