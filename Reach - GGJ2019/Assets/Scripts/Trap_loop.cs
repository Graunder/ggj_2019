using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap_loop : MonoBehaviour
{

   
    public GameObject lazer;
    private bool trapEnabled = true;
    public GameObject particles;

    void Start()
    {
        particles.SetActive(false);
        InvokeRepeating("ToogleTrap", 0, Random.Range(0.5f, 1.5f));
    }

    private void ToogleTrap() {
        StartCoroutine(Fire());
       

    }
    public IEnumerator Fire()
    {
        particles.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        trapEnabled = !trapEnabled;
        lazer.SetActive(trapEnabled);
        particles.SetActive(trapEnabled);
    }

}
