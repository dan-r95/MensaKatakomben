using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchSceneAfterXSeconds : MonoBehaviour
{
    // Start is called before the first frame update
	public float durationTime = 10f;
	public int sceneIndex = 1;
    void Start()
    {
		
		// In a function
		 //replace the int with level number
		StartCoroutine(Example());
	}

	IEnumerator Example()
	{
		print(Time.time);
		yield return new WaitForSeconds(durationTime);
		SceneManager.LoadScene(sceneIndex);
	}
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
