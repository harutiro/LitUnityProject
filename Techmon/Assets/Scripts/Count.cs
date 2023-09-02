using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Count: MonoBehaviour
{
    public int number = 0;
    public Text powerText;
    public Text dammageTest;
    int total;

    public AudioSource audioSource;
    public AudioClip SE;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (total > 100)
        {
            Debug.Log("きた");
            SceneManager.LoadScene("GameClear");
        }
    }

    public void CountUp()
    {
        number++;
        powerText.text = number.ToString();
    }

    public void Attack()
    {
        total += number;
        dammageTest.text = total.ToString();

        number = 0;
        powerText.text = number.ToString();

        audioSource.PlayOneShot(SE);


        
    }
}
