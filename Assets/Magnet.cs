using UnityEngine;
using System.Collections;

public class Magnet : MonoBehaviour
{
    public CubeRecorder recorder;

    void Update()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, transform.localScale.x * 1.5f);

        foreach(Collider collider in colliders)
        {
            if (collider.transform.localScale == transform.localScale && recorder.reverse == false)
            {
                Vector3 dir = transform.position - collider.transform.position;
                collider.GetComponent<Rigidbody>().AddForce(dir / 2500);
            }
        }
    }
}