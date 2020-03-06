using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMass : MonoBehaviour
{
    Rigidbody rigidbody;
    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "DraggableBlock")
        {
            rigidbody.drag = 4.5f;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "DraggableBlock")
        {
            rigidbody.drag = 12.5f;
        }
    }
}
