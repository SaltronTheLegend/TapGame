using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource explosionSound;
    
    public void playSound()
    {
        explosionSound.Play();
    }


}
