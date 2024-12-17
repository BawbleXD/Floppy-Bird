using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    public LogicScript logic;
    public BirdScipt bird;

    // Start is called before the first frame update
    void Start()
    {
        //Look through hierachy with gameobject with tag "Logic"
        // Then find LogicScipt from the object
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        bird = GameObject.FindGameObjectWithTag("Bird").GetComponent<BirdScipt>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // function will run when object hits trigger
    private void OnTriggerEnter2D (Collider2D collision)
    {
        // If bird still alive..
        if (bird.birdIsAlive == true)
        {
            // If the bird (In layer 3) collides with trigger...
            if (collision.gameObject.layer == 3)
            {
                //Run public function to add score
                logic.addScore(1);
            }
        }
    
    }
}
