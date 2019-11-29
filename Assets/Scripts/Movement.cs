using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    Animator anim;

    [SerializeField]

    private Rigidbody2D rb;

    private float jumpForce = 600f;

    public AudioSource bckground;

    public MoveLeftCycle move;

    public ScoreManager score;


    public Text loseText;
 





    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        bckground = GetComponent<AudioSource>();
        score = FindObjectOfType<ScoreManager>();
        loseText.text = "";

    }


    void Update()
    {




        if (Input.GetKeyDown(KeyCode.Space))
        {

            rb.AddForce(Vector2.up * jumpForce);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            anim.ResetTrigger("Normal");
            anim.SetTrigger("RunDown");
            Debug.Log("Down Arrow");
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {

            anim.ResetTrigger("RunDown");
            anim.SetTrigger("Normal");
            Debug.Log("UpArrow Key");
        }

    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Finish")) {


            rb.gameObject.SetActive(false);
            move.gameObject.SetActive(false);
            score.scoreText.gameObject.SetActive(false);
            score.highScoreText.gameObject.SetActive(false);
            loseText.gameObject.SetActive(true);
            loseText.text = "YOU LOSE !";
           
        }

    }

}


