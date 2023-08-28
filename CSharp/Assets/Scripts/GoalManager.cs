using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalManager : MonoBehaviour
{

    public GameObject playerOneText;
    public GameObject playerTwoText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            int ID = collision.gameObject.GetComponent<PlayerController>().ID;
            if(ID == 0)
            {
                playerOneText.SetActive(true);
            }else if(ID == 1)
            {
                playerTwoText.SetActive(true);
            }
        }
    }
}
