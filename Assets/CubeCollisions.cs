using UnityEngine;
using System.Collections;

public class CubeCollisions : MonoBehaviour
{
    public bool shatter;

    void Start()
    {
        shatter = false;
        Invoke("Shatter", 0.25f);
    }

    void Shatter()
    {
        shatter = true;
    }

    void OnCollisionEnter(Collision col)
    {
        if (shatter == true && col.transform.localScale.x > transform.localScale.x && GetComponent<CubeRecorder>().reverse == false && transform.localScale.x > 0.05 && transform.localScale.x >= 0.125f)
        {
            GameObject obj;
            obj = Instantiate(gameObject) as GameObject;
            obj.transform.Translate(obj.transform.localScale / 4);
            obj.GetComponent<Rigidbody>().AddForce(obj.transform.localScale / 4);
            obj.transform.localScale = obj.transform.localScale / 2;

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

        if(col.transform.localScale.x == transform.localScale.x && shatter == true && GetComponent<CubeRecorder>().reverse == false && transform.position.x > col.transform.position.x)
        {
            Vector3 pos = (transform.position + col.transform.position) / 2;
            GameObject obj;
            obj = Instantiate(gameObject, pos, Quaternion.identity) as GameObject;
            obj.transform.localScale = transform.localScale * 1.5f;

            gameObject.GetComponent<Collider>().enabled = false;
            gameObject.GetComponent<Renderer>().enabled = false;
            gameObject.GetComponent<Rigidbody>().isKinematic = true;
            col.gameObject.GetComponent<Collider>().enabled = false;
            col.gameObject.GetComponent<Renderer>().enabled = false;
            col.gameObject.GetComponent<Rigidbody>().isKinematic = true;
        }
    }
}
