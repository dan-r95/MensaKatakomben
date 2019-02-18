using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetFrameRate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Awake()
    {
        // 0 for no sync, 1 for panel refresh rate, 2 for 1/2 panel rate

        QualitySettings.vSyncCount = 0;
        // Make the game run at 30fps
        Application.targetFrameRate = 30;
    }

}
