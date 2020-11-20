using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Uranus : MonoBehaviour {
    [SerializeField]
    public GameObject UranusPanel;

    void OnMouseDown () {
        StartCoroutine (UranusInfo ());
    }

    IEnumerator UranusInfo () {

        UranusPanel.SetActive (true);
        yield return new WaitForSeconds (4.0f);
        // UranusPanel.SetActive (false);

    }
}