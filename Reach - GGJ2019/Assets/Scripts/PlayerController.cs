﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    [Range(1, 10)]
    public float jumpVelocity;

    [Range(1, 10)]
    public float runSpeed;

    public float distToGround;
    [SerializeField]
    public bool grounded = true;

    private void OnTriggerStay(Collider other) {
        if (other.transform.CompareTag("ground")) {
            grounded = true;
        }

    }
    private void OnTriggerExit(Collider other) {
        if (other.transform.CompareTag("ground")) {
            grounded = false;
        }
    }


    //private void Update() {
    //    //grounded = Physics.BoxCast(boxCol.bounds.center, boxCol.bounds.extents, Vector3.down, transform.rotation, Mathf.Infinity, lm);

    //    Ray ray = new Ray(transform.position, -transform.up);
    //    grounded = Physics.SphereCast(ray,5f, 50f, lm);

    //}

    void FixedUpdate(){

        if (Input.GetButtonDown ("Jump") && grounded == true) {
            GetComponent<Rigidbody>().velocity = Vector3.up * jumpVelocity;
        }

        //grounded = Mathf.Abs(GetComponent<Rigidbody>().velocity.y) < 0.5f;

        this.transform.Translate(Input.GetAxis("Horizontal") * runSpeed * Time.deltaTime, 0, 0);

    }

//            if (Input.GetButtonDown("Jump") && grounded == true) {
//            GetComponent<Rigidbody>().velocity = Vector3.up* jumpVelocity;
//}
//grounded = Mathf.Abs(GetComponent<Rigidbody>().velocity.y) < 0.5f;
//        ////grounded = IsGrounded();

//        this.transform.Translate(Input.GetAxis("Horizontal") * runSpeed * Time.deltaTime, 0, 0);

}
