using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change : MonoBehaviour
{

    Score score;

    // Start is called before the first frame update
    void Start()
    {
        score = gameObject.GetComponent<Score>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            score.number++;
            Debug.Log("ScoreスクリプトのNumber変数" + score.number);
        }
    }
}
