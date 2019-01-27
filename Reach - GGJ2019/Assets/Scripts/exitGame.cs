using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitGame : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            StartCoroutine(quit());
        }
    }

    IEnumerator quit() {

        yield return new WaitForSeconds(2);
        Application.Quit();

    }
}
