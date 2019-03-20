using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class StartVideo : MonoBehaviour
{
    public VideoPlayer video;
    public float StartTime = 0f;

    void Start(){
        StartCoroutine(Timeline());
    }

    private IEnumerator Timeline(){

        yield return new WaitForSeconds(StartTime);
        video.Play();
    }
}
