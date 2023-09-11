using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    int[] scores = new int[] { 1, 2, 3, 4, 5 };
    int Count;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 1; i < 5; i++)
        {
            scores[i] = scores[i] + scores[i - 1];
        }
        Debug.Log(scores[scores.Length - 1]);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.transform.position = Vector3.zero;
        }
    }
}
