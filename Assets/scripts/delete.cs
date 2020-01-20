using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class delete : MonoBehaviour
{
  public Text winText;
  private bool game = false;
  private bool time2 = false;

    public float timeLeft = 3.0f;
 
   public Text Timers;

   public Text lossgame;
   
    public AudioClip musicClip;

    public AudioClip musicCliptwo;

public AudioSource musicSource2;

public AudioSource musicSource3;

public AudioSource musicSource4;


 

  void start(){
     winText.text = "";

       
     lossgame.text ="";
  }

    void Update()
   {
        timeLeft -= Time.deltaTime;
        Timers.text = (timeLeft).ToString("0");

        if (timeLeft < 0)
       {
           timeLeft = 0;
           time2 = true;
       }

    if( game == false && time2 == true)
    {
        lossgame.text ="you loss";
        Time.timeScale = 0;
 
        musicSource2.clip =  musicCliptwo;

        musicSource2.Play();

                musicSource4.Stop();

         
    }

       

       if(game ==true && time2 == false)

        {
              winText.text = "YOu Win Made by Richard Derkman";
              Time.timeScale = 0;

              musicSource3.clip = musicClip;

              musicSource3.Play();
               
               musicSource4.Stop();
  
        }
            
   }

  void OnCollisionEnter2D(Collision2D coll) {
       
         if (coll.gameObject.tag == "gamewin") {
            game = true;
             Destroy(coll.gameObject);

         }
     }
}
