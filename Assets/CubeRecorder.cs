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
    public GameObject button;

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
            index -= 4;

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
                    button.name = "Buttton";
                }
                else
                {
                    Destroy(gameObject);
                }
            }
        }

        if(button.name == "Button Pressed" && reverse == false && positions.Count > 0)
        {
            index = positions.Count - 1;
            reverse = true;
        }

        if(GetComponent<Collider>().enabled == false && splitIndex == 0)
        {
            splitIndex = positions.Count - 1;
        }
    }
}
