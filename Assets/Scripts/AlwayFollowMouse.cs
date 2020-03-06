using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlwayFollowMouse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distance_to_screen = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        float y = Input.mousePosition.y;
        if (y <= 103)
        {
            y = 103;
        }
        transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, y, distance_to_screen));
    }
}
