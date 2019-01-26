using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap_FallOnExit : MonoBehaviour
{

    public GameObject trap;
    public GameObject trigger;

    private void OnTriggerExit(Collider trigger) {
        if (trigger.CompareTag("Player")) {

            stuffz();

        }
    }

    void stuffz() {
        Rigidbody trapRigidbody = trap.GetComponent<Rigidbody>();
        trapRigidbody.isKinematic = false;
    }

}
