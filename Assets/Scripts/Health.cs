using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Health : MonoBehaviour
{
   public int health;
   public LoaderScene loaderScene;
   public int numOfHearts;

   public int livesRemaining;

   public Image[] hearts;
   public Sprite fullHeart;
   public Sprite emptyHeart;
   [SerializeField] AudioClip Damage; 
   AudioSource audioSource;

    void Start() 
    {   
        audioSource = GetComponent<AudioSource>();
        livesRemaining = numOfHearts;
        foreach(Image heart in hearts)
        {
            heart.enabled = false;
        }
        for(int i = 0; i < numOfHearts; i++)
        {
            
            hearts[i].sprite = fullHeart;
            hearts[i].enabled = true;
        }
       
    }
    public void DecreaseLife(int timesToDecrease)
    {
        for(int i = 0; i < timesToDecrease; i++)
        {
            livesRemaining--;
            hearts[livesRemaining].sprite = emptyHeart;
        }
        
        numOfHearts = livesRemaining;
        audioSource.PlayOneShot(Damage);
        if (numOfHearts <= 0)
        {
            Debug.Log("YO PLS WORK OR I KILL");
            loaderScene.SceneReloader();
        }
        
    }

        public void IncreaseLife(int timesToIncrease)
    {
        for(int i = 0; i <timesToIncrease; i++)
        {
            hearts[livesRemaining].sprite = fullHeart;
            livesRemaining++;
            
            
        }
        numOfHearts = livesRemaining;
        Debug.Log("you have this many hearts" + livesRemaining);
    }

}