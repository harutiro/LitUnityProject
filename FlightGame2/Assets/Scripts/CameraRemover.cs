using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRemover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RemoveCamera()
    {
        transform.parent = null;
    }
}
