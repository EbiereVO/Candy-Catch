using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    bool canMove = true;
    [SerializeField] float maxPose;
    [SerializeField] float moveSpeed;


    void Start()
    {
        
    }

    
    void Update()
    {
        if (canMove)
        {
            MovePlayer();
        }
    }

    void MovePlayer()
    {
        float inputX = Input.GetAxis("Horizontal");
        transform.position += Vector3.right * inputX * moveSpeed * Time.deltaTime;

        float xPos = Mathf.Clamp(transform.position.x, -maxPose, maxPose);
        transform.position = new Vector3(xPos, transform.position.y, transform.position.z);
       
    }
}
