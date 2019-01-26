using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class went : MonoBehaviour
{
    [Range(-350, 350)]
    public int forceX;
    [Range(-350, 350)]
    public int forceY;

    private void OnTriggerStay(Collider other) {
        if (other.CompareTag("Player")) {

            other.attachedRigidbody.AddForce(forceX, forceY, 0);

        }
    }
}
