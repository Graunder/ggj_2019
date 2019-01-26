using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class went : MonoBehaviour
{
    [Range(-50, 50)]
    public int forceX;
    [Range(-50, 50)]
    public int forceY;

    private void OnTriggerStay(Collider other) {
        if (other.CompareTag("Player")) {

            other.attachedRigidbody.AddForce(forceX, forceY, 0);

        }
    }
}
