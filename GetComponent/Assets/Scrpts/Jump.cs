using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{

    public float power = 500f;
    Rigidbody cubyRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        cubyRigidbody = this.gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            cubyRigidbody.AddForce(Vector3.up * power);
        }
    }
}
