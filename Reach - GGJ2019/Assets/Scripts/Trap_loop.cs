using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap_loop : MonoBehaviour
{

   
    public GameObject lazer;
    private bool trapEnabled = true;

    void Start()
    {
        InvokeRepeating("ToogleTrap", 0, Random.Range(0.5f, 1.5f));
    }

    private void ToogleTrap() {

        trapEnabled = !trapEnabled;
        lazer.SetActive(trapEnabled);

    }

}
