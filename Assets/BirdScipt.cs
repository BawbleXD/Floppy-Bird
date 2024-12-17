using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScipt : MonoBehaviour
{
    //public means that you can edit the component in unity
    public Rigidbody2D myRigidBody; 
    public float flapStrength;
    public LogicScript logic;
    public BirdFlapScript BirdFlap;
    public bool birdIsAlive = true;


    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        BirdFlap = GameObject.FindGameObjectWithTag("BirdFlapAudio").GetComponent<BirdFlapScript>();
    }

    // Update is called once per frame
    void Update()
    {
        offScreenDeath();

        //If user presses space bar and bird is alive....
        if (Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive == true)
        {
        //Vector2.up == (0,1) Go up by one in coordinate plane
        myRigidBody.velocity = Vector2.up * flapStrength;
        BirdFlap.birdFlapAudio();
        }
    }

    // function to kill bird when it goes beyond bounds
    void offScreenDeath()
    {
        if (transform.position.y >= 8)
        {
            logic.gameOver();
            birdIsAlive = false;
        }
        else
        {
            if (transform.position.y <= -12)
            {
                logic.gameOver();
                birdIsAlive = false;
            }
        }
    }

    // function that if collision...
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // call gameover function
        logic.gameOver();
        birdIsAlive = false;
    }
}
