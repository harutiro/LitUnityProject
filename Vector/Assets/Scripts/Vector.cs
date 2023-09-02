using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(3, 3, 3);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position -= new Vector3(Time.deltaTime, 0, 0);
        //Debug.Log(transform.position.magnitude);

        if(transform.localEulerAngles.z < 60)
        {
            transform.Rotate(Vector3.left, Space.World);

        }
    }
}
