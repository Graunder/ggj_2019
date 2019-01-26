using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap_loop : MonoBehaviour
{

    [SerializeField]
    private GameObject lazer;
    private bool trapEnabled = true;

    void Start()
    {
        InvokeRepeating("ToogleTrap", 0, 1.5f);
    }

    private void ToogleTrap() {

        trapEnabled = !trapEnabled;
        lazer.SetActive(trapEnabled);

    }

}
