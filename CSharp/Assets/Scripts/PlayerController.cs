using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    float moveSpeed = 5.0f;
    float rotateSpeed = 30.0f;


    public int ID;

    KeyCode forwarKey;
    KeyCode rightKey;
    KeyCode leftKey;

    // Start is called before the first frame update
    void Start()
    {
        if(ID == 0)
        {
            forwarKey = KeyCode.W;
            rightKey = KeyCode.D;
            leftKey = KeyCode.A;
        }
        else if( ID == 1)
        {
            forwarKey = KeyCode.UpArrow;
            rightKey = KeyCode.RightArrow;
            leftKey = KeyCode.LeftArrow;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(forwarKey))
        {
            transform.Translate(0, 0, moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(rightKey))
        {
            transform.Rotate(0, rotateSpeed * Time.deltaTime, 0);
        }
        if (Input.GetKey(leftKey))
        {
            transform.Rotate(0, -rotateSpeed * Time.deltaTime, 0);
        }
    }
}
