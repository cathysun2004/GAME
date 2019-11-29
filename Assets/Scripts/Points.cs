using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    public int scoreToGive;

    private ScoreManager theScoreManager;

    public GameObject coin;

    void Start()
    {
        theScoreManager = FindObjectOfType<ScoreManager>();
    }


    void Update()
    {
       
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Knight") {

            theScoreManager.scoreCount += scoreToGive;
            gameObject.SetActive(false);


            coin.gameObject.SetActive(false);
        
        }
    }
}
