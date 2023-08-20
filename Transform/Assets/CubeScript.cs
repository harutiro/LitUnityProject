using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{

    float number = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(10, 0, 10);
        transform.rotation = Quaternion.Euler(45, 45, 45);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 0, number));
        transform.Rotate(new Vector3(1, 1, 1));
        transform.localScale += new Vector3(number, number, number);
    }
}
