using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLegs : MonoBehaviour
{
    public static PlayerLegs instance;

    private bool isGrounded = false;

    private void Awake() {
        if (null == instance) {
            instance = this;
        }
    }

    private void OnTriggerStay(Collider other) {
        if (other.transform.CompareTag("ground")) {
            isGrounded = true;
        }

    }
    private void OnTriggerExit(Collider other) {
        if (other.transform.CompareTag("ground")) {
            isGrounded = false;
        }
    }

    public bool IsGrounded() {
        return this.isGrounded;
    }
}
