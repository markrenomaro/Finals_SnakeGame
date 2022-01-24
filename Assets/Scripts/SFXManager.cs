using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
    public static AudioClip playerEat, playerDeath;
    static AudioSource audioSrc;

    void Start()
    {
        playerEat = Resources.Load<AudioClip> ("ChompSFX");
        playerDeath = Resources.Load<AudioClip> ("BumpSFX");
        audioSrc = GetComponent<AudioSource> ();
    }

    void Update()
    {
        
    }

    public static void PlaySound (string clip)
    {
        switch (clip){
            case "ChompSFX":
                audioSrc.PlayOneShot (playerEat);
            break;
            case "BumpSFX":
                audioSrc.PlayOneShot (playerDeath);
            break;

        }
    }
}
