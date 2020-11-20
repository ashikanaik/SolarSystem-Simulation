using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mars : MonoBehaviour {
    [SerializeField]
    public GameObject MarsPanel;

    void OnMouseDown () {
        StartCoroutine (MarsInfo ());
    }

    IEnumerator MarsInfo () {

        MarsPanel.SetActive (true);
        yield return new WaitForSeconds (4.0f);
        // MarsPanel.SetActive (false);

    }
}