using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHideObject : MonoBehaviour
{
    public GameObject ShowObject;
    public float ShowTime = 0f;
    public float HideTime = 10f;

    void Start(){
        StartCoroutine(Timeline());
    }

    private IEnumerator Timeline(){
        ShowObject.SetActive(false);
        yield return new WaitForSeconds(ShowTime);
        ShowObject.SetActive(true);
        yield return new WaitForSeconds(HideTime - ShowTime);
        ShowObject.SetActive(false);
    }
}
