using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [Range(1, 10)]
    public float jumpVelocity;

    [Range(1, 10)]
    public float runSpeed;

    public float distToGround;
    public bool grounded;

    public bool CheckIfGrounded() {

        grounded = Physics.Raycast(transform.position, -Vector3.up, distToGround + 0.5f);
        return grounded;

    }

    void FixedUpdate(){

        if (Input.GetButtonDown ("Jump") && CheckIfGrounded()) {
            GetComponent<Rigidbody>().velocity = Vector3.up * jumpVelocity;
        }

        this.transform.Translate(Input.GetAxis("Horizontal") * runSpeed * Time.deltaTime, 0, 0);

    }
}
