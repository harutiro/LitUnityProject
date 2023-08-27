using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayDisplayer : MonoBehaviour
{
    int[] scores = new int[] { 2, 5, 10 };

    // Start is called before the first frame update
    void Start()
    {

        scores[0] = 5;
        scores[1] = scores[0] + 5;
        scores[2] = scores[2] * 2;

        Debug.Log(scores[0]);
        Debug.Log(scores[1]);
        Debug.Log(scores[2]);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
