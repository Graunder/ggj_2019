using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public Animator anim;
    public float fallMultiplier = 2.5f;
    public float lowJumpMultiplier = 2f;
    Rigidbody body;

    private void Awake(){

        body = GetComponent<Rigidbody>();

    }
    private void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }
    void Update(){
        //if (Input.GetButton("Jump"))
        if (Input.GetKey(KeyCode.UpArrow))
        {
            anim.SetBool("isJumping", true);
        }
        if (body.velocity.y < 0){
            anim.SetBool("isJumping", true);
            body.velocity += Vector3.up * Physics.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        } else if (body.velocity.y > 0 && !Input.GetKey(KeyCode.UpArrow)) {
            anim.SetBool("isJumping", true);
            body.velocity += Vector3.up * Physics.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;
        }
        else if(body.velocity.y == 0)
        {
            anim.SetBool("isJumping", false);

        }

    }
}
