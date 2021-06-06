using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{

    AudioSource audioSource;
    AudioClip soundtrack;
   
   void Awake() 
   {
        int numOfMusicPlayers = FindObjectsOfType<MusicPlayer>().Length;
        if(numOfMusicPlayers > 1)
        {
            Destroy(gameObject);
        }    
        else
        {
            DontDestroyOnLoad(gameObject);
        }
   }
}
