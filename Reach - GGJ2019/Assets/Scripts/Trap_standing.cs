using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap_standing : MonoBehaviour
{

    public GameObject trap;
    public GameObject trigger;

    //private void OnTriggerEnter(Collider trigger) {

    //    if (trigger.CompareTag("Player")) {

    //        Rigidbody trapRigidbody = trap.GetComponent<Rigidbody>();
    //        trapRigidbody.isKinematic = false;

    //    }

    //}

    bool TimerStarted = false;

    void OnTriggerEnter(Collider trigger) {
        if (trigger.CompareTag("Player") && !TimerStarted) {

            TimerStarted = true;

        }
    }

    private float _timer = 0f;
    public float TimeIWantInSeconds = 0.05f;

    void Update() {
        if (TimerStarted) {
            _timer += Time.deltaTime;

            if (_timer >= TimeIWantInSeconds) {
                Rigidbody trapRigidbody = trap.GetComponent<Rigidbody>();
                trapRigidbody.isKinematic = false;
            }
        }
    }

}
