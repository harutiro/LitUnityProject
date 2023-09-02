using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundContoller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);//シーンを切り替えても生き残る
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
