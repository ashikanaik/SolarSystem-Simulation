using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canvas : MonoBehaviour {
    [SerializeField]
    public GameObject WelcomePanel;
    [SerializeField]
    public GameObject TextMsg;
    [SerializeField]
    // public GameObject SunPanel;
    // [SerializeField]
    // public GameObject JupiterPanel;
    // GameObject sun;
    IEnumerator Start () {
        WelcomePanel.SetActive (true);
        yield return new WaitForSeconds (2.0f);
        WelcomePanel.SetActive (false);
        TextMsg.SetActive (true);
        yield return new WaitForSeconds (3.0f);
        TextMsg.SetActive (false);
    }

    // void OnMouseDown () {

    //      GameObject.FindGameObjectWithTag ("Sun");
    //     if (sun.tag=="Sun") {
    //         Debug.Log ("Tag idenitified");

    //         StartCoroutine (Sun ());

    //         Debug.Log ("Coroutine called");

    //     }
    // }

    // IEnumerator Sun () {
    //     Debug.Log ("Entered Sun");
    //     SunPanel.SetActive (true);
    //     yield return new WaitForSeconds (4.0f);
    //     SunPanel.SetActive (false);
    //     Debug.Log ("SunPAnel turned off");

    // }

}