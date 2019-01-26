using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class went : MonoBehaviour
{
    [Range(1, 50)]
    public int forceX;
    [Range(1, 50)]
    public int forceY;
    [Range(1, 50)]
    public int forceZ;

    private void OnTriggerStay(Collider other) {
        if (other.CompareTag("Player")) {

            other.attachedRigidbody.AddForce(forceX, forceY, forceZ);

        }
    }
}
