using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    private float timer = 0;
    public float heightOffset = 10;

    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        // If timer less than spawnRate
        if (timer < spawnRate)
        {
            // Count the timer up
            timer = timer + Time.deltaTime;
        } 
        else
        {
            // Call spawnPipe function
            spawnPipe();
            // Restart timer
            timer = 0;
        }

    }

    // Function to spawn pipe
    void spawnPipe ()
    {
        // Highest and lowest point pipe can spawn
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        // Make pipe spawn in random Y axis
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
