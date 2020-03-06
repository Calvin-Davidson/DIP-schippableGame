using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    Transform camTrans;

    private void Start()
    {
        camTrans = GameObject.Find("Main Camera").GetComponent<Transform>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            camTrans.position = new Vector3(camTrans.position.x, camTrans.position.y + 2.5f * Time.deltaTime, camTrans.position.z);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            if (camTrans.position.y - 1f * Time.deltaTime <= 2.5f)
            {
                camTrans.position = new Vector3(camTrans.position.x, 2.5f, camTrans.position.z);
            }
            else
            {
                camTrans.position = new Vector3(camTrans.position.x, camTrans.position.y - 2.5f * Time.deltaTime, camTrans.position.z);
            }
        }
    }
}
