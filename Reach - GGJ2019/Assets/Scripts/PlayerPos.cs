﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPos : MonoBehaviour
{

    private GameMaster gm;

    void Start() {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        transform.position = gm.lastCheckpointPos;
    }

    private void OnTriggerEnter(Collider other) {

        if (other.gameObject.tag == "Kill") {

            AudioManager.instance.setTime();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            
        }

    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Kill")
        {
            AudioManager.instance.setTime();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }
    }

}
