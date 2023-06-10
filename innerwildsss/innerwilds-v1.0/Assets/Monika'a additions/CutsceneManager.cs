using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Playables;

public class CutsceneManager : MonoBehaviour
{
    /* private PlayableDirector director;
     public GameObject controlPanel;

     public GameObject Player;
     public GameObject cutSceneCam;

     private void Awake()
     {
         director = GetComponent<PlayableDirector>();
         director.played += Director_Played;
         director.stopped += Director_Stopped;

     }

     private void OnTriggerEnter();
     {
         cutSceneCam.SetActive(true);
         Player.SetActive(false); 
         director.Play(); 
     }
     */

    [SerializeField] private PlayableDirector manager;
    private bool firstTime = true;

    private void Update()
    {
        
      if (manager.time == 0)
      {
            if (firstTime) {
                firstTime  = false;
            } else
            {
                gameObject.SetActive(false);
            }
            

      }

    }
    
}
