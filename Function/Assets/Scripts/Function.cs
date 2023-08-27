using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Function : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int number = Sum(5, 3);
        Debug.Log(number);

        HelloYourName("Life is Tech!");
    }

    // Update is called once per frame
    void Update()
    {

    }


    int Sum(int x, int y)
    {
        return x + y;

    }

    void HelloYourName(string name)
    {
        string message = "Hello" + name;
        Debug.Log(message);
    }
}
