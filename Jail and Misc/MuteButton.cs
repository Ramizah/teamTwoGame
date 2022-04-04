using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Created by Caleb

public class MuteButton : MonoBehaviour
{

   //Mute button mutes itself first after game restart, not too big as it can be undone by clicking mute again, but still annoying
   
   public void MuteToggle(bool Mute)
   {
      if(Mute)
      {
         AudioListener.volume = 0;
      }

      else
      {
         AudioListener.volume = 0.6f;
      }
   }
   
}
