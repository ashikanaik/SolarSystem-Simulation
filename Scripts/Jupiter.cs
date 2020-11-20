using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jupiter : MonoBehaviour {
    [SerializeField]
    public GameObject JupiterPanel;

    void OnMouseDown () {
        StartCoroutine (JupiterInfo ());
    }

    IEnumerator JupiterInfo () {

        JupiterPanel.SetActive (true);
        yield return new WaitForSeconds (4.0f);
        // JupiterPanel.SetActive (false);

    }
}