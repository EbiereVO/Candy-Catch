using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyScript : MonoBehaviour
{
    //public GameObject gameObject;
    int score = 25;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            score++;
            Destroy(gameObject);
            Debug.Log(score);
        }

        else if (collision.gameObject.tag == "Boundary")
        {
            score--;
            Destroy(gameObject);
            Debug.Log(score);
        }

    }
}
