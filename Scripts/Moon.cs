using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moon : MonoBehaviour {
    [SerializeField]
    public GameObject MoonPanel;

    void OnMouseDown () {
        StartCoroutine (MoonInfo ());
    }

    IEnumerator MoonInfo () {

        MoonPanel.SetActive (true);
        yield return new WaitForSeconds (4.0f);
        // MoonPanel.SetActive (false);

    }
}