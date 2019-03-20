using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
public class TimeController : MonoBehaviour
{
    public float TimeSpeed = 1;
    private float previousTimeSpeed = 1;

    public List<VideoPlayer> videoPlayers;

    // Update is called once per frame
    void Update()
    {
        if(TimeSpeed < 0){
            TimeSpeed = 0;
        }
        if(TimeSpeed != previousTimeSpeed){
            previousTimeSpeed = TimeSpeed;
            Time.timeScale = TimeSpeed;
            foreach(var player in videoPlayers){
                player.playbackSpeed = TimeSpeed;
            }
        }
        
    }
}
