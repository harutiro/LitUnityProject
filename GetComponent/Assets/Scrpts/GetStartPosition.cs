using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetStartPosition : MonoBehaviour
{

    public GameObject cuby;
    // Start is called before the first frame update
    void Start()
    {
        cuby.transform.position = new Vector3(0, 2, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
