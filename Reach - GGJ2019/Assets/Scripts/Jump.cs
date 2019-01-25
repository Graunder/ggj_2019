using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{

    public float fallMultiplier = 2.5f;
    public float lowJumpMultiplier = 2f;
    Rigidbody body;

    private void Awake(){

        body = GetComponent<Rigidbody>();

    }

    void Update(){

        if (body.velocity.y < 0){
            body.velocity += Vector3.up * Physics.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        } else if (body.velocity.y > 0 && !Input.GetButton("Jump")){
            body.velocity += Vector3.up * Physics.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;
        }

    }
}
