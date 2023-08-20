using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{

    string debugText = "Hello LiT!";

    int myAge = 19;
    int menterAge = 22;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(debugText);
        Debug.Log(myAge + menterAge);
    }
}
