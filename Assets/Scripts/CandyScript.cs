using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyScript : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Manager.instance.incrementScore();
            Destroy(gameObject);
        }

        else if (collision.gameObject.tag == "Boundary")
        {
            Destroy(gameObject);
        }

    }
}
