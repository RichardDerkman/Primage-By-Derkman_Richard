using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
  float currentTime = 0f;
  float startTime = 10f;
 
   public Text Timers;
   public Text lossgame;
   
   private void start()
   {
       currentTime = startTime;
       
       lossgame.text ="";
       
   }

   private void Update()
   {
       currentTime -= 1 * Time.deltaTime;
       Timers.text = currentTime.ToString("0");

       if( currentTime <= 0)
       {
           currentTime = 0;
       }
    
   }
   
}
