using UnityEngine;
using System.Collections;

public class CubeShatter : MonoBehaviour 
{
    public Material material;

    void Start()
    {
        gameObject.GetComponent<Renderer>().material.color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
        gameObject.GetComponent<Rigidbody>().mass = transform.localScale.x / 100;
    }

    void OnMouseDown()
    {
        GameObject obj;
        obj = Instantiate(gameObject) as GameObject;
        obj.transform.Translate(obj.transform.localScale / 4);
        obj.GetComponent<Rigidbody>().AddForce(obj.transform.localScale / 4);
        obj.transform.localScale = obj.transform.localScale/2;

        obj = Instantiate(gameObject) as GameObject;
        obj.transform.Translate((obj.transform.localScale / 4) - new Vector3(0, 0, obj.transform.localScale.z / 2));
        obj.GetComponent<Rigidbody>().AddForce((obj.transform.localScale / 4) - new Vector3(0, 0, obj.transform.localScale.z / 2));
        obj.transform.localScale = obj.transform.localScale / 2;

        obj = Instantiate(gameObject) as GameObject;
        obj.transform.Translate((obj.transform.localScale / 4) - new Vector3(obj.transform.localScale.x / 2, 0, obj.transform.localScale.z / 2));
        obj.GetComponent<Rigidbody>().AddForce((obj.transform.localScale / 4) - new Vector3(obj.transform.localScale.x / 2, 0, obj.transform.localScale.z / 2));
        obj.transform.localScale = obj.transform.localScale / 2;

        obj = Instantiate(gameObject) as GameObject;
        obj.transform.Translate((obj.transform.localScale / 4) - new Vector3(obj.transform.localScale.x / 2, 0, 0));
        obj.GetComponent<Rigidbody>().AddForce((obj.transform.localScale / 4) - new Vector3(obj.transform.localScale.x / 2, 0, 0));
        obj.transform.localScale = obj.transform.localScale / 2;

        obj = Instantiate(gameObject) as GameObject;
        obj.transform.Translate((obj.transform.localScale / 4) - new Vector3(0, obj.transform.localScale.y / 2, 0));
        obj.GetComponent<Rigidbody>().AddForce((obj.transform.localScale / 4) - new Vector3(0, obj.transform.localScale.y / 2, 0));
        obj.transform.localScale = obj.transform.localScale / 2;

        obj = Instantiate(gameObject) as GameObject;
        obj.transform.Translate((obj.transform.localScale / 4) - new Vector3(0, obj.transform.localScale.y / 2, obj.transform.localScale.z / 2));
        obj.GetComponent<Rigidbody>().AddForce((obj.transform.localScale / 4) - new Vector3(0, obj.transform.localScale.y / 2, obj.transform.localScale.z / 2));
        obj.transform.localScale = obj.transform.localScale / 2;

        obj = Instantiate(gameObject) as GameObject;
        obj.transform.Translate((obj.transform.localScale / 4) - new Vector3(obj.transform.localScale.x / 2, obj.transform.localScale.y / 2, obj.transform.localScale.z / 2));
        obj.GetComponent<Rigidbody>().AddForce((obj.transform.localScale / 4) - new Vector3(obj.transform.localScale.x / 2, obj.transform.localScale.y / 2, obj.transform.localScale.z / 2));
        obj.transform.localScale = obj.transform.localScale / 2;

        obj = Instantiate(gameObject) as GameObject;
        obj.transform.Translate((obj.transform.localScale / 4) - new Vector3(obj.transform.localScale.x / 2, obj.transform.localScale.y / 2, 0));
        obj.GetComponent<Rigidbody>().AddForce((obj.transform.localScale / 4) - new Vector3(obj.transform.localScale.x / 2, obj.transform.localScale.y / 2, 0));
        obj.transform.localScale = obj.transform.localScale / 2;

        gameObject.GetComponent<Collider>().enabled = false;
        gameObject.GetComponent<Renderer>().enabled = false;
        gameObject.GetComponent<Rigidbody>().isKinematic = true;
    }
}
