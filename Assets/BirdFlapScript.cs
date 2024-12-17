using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdFlapScript : MonoBehaviour
{
    public AudioSource Flap1SFX;
    public AudioSource Flap2SFX;
    public AudioSource Flap3SFX;
    
    // Make random bird flaps between 3 seperate flap audio's.
    public void birdFlapAudio()
    {
        int randint = Random.Range(1,3);
        if (randint == 1)
        {
            Flap1SFX.Play();
        }
        else if (randint == 2)
        {
            Flap2SFX.Play();
        }
        else
        {
            Flap3SFX.Play();
        }
    }

}
