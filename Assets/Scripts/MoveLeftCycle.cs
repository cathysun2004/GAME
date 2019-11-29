using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftCycle : MonoBehaviour
{
  
    [SerializeField]
    float moveSpeed = -5f;
    [SerializeField]
    float leftWayPontX = -8f, rightWayPointX = 8f;

    private ScoreManager theScoreManager;
  

    void Update()
    {
        transform.position = new Vector2(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y);


        if (transform.position.x < leftWayPontX)
            transform.position = new Vector2(rightWayPointX, transform.position.y);

       if (theScoreManager.scoreCount> 4f ) {

          
       
       
       }

    }
}
