using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Earth : MonoBehaviour {
    [SerializeField]
    public GameObject EarthPanel;

    void OnMouseDown () {
        StartCoroutine (EarthInfo ());
    }

    IEnumerator EarthInfo () {

        EarthPanel.SetActive (true);
        yield return new WaitForSeconds (4.0f);
        // EarthPanel.SetActive (false);

    }
}