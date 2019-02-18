using UnityEngine;
using RockVR.Video;


public class CaptureOnKeyPress : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if(Input.GetKeyDown(KeyCode.C)) {
			VideoCaptureCtrl.instance.StartCapture();
		}
		if(Input.GetKeyDown(KeyCode.Escape)) {
			VideoCaptureCtrl.instance.StopCapture();
		}
    }
}


