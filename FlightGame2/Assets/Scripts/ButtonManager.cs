using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Title()
    {
        SceneManager.LoadScene("Title");
    }

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Main1()
    {
        SceneManager.LoadScene("Main 1");
    }

    public void Main2()
    {
        SceneManager.LoadScene("Main 2");
    }

    public void Main3()
    {
        SceneManager.LoadScene("Main 3");
    }
}
