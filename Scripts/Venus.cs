using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Venus : MonoBehaviour {
    [SerializeField]
    public GameObject VenusPanel;

    void OnMouseDown () {
        StartCoroutine (VenusInfo ());
    }

    IEnumerator VenusInfo () {

        VenusPanel.SetActive (true);
        yield return new WaitForSeconds (4.0f);
        // VenusPanel.SetActive (false);

    }
}