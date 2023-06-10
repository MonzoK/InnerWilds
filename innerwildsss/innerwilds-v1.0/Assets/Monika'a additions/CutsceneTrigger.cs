using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class CutsceneTrigger : MonoBehaviour
{
    public GameObject Player;
    public GameObject cutSceneCam;
    private PlayableDirector timeline;

    private void Start()
    {
        timeline= GetComponent<PlayableDirector>();
    }
    private void OnTriggerEnter(Collider a)
    {
        cutSceneCam.SetActive(true);
        Player.SetActive(false);
       
        if (a.gameObject.tag == "Player" )
        {
            timeline.Play();
        }
    }
}
