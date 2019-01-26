using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class GameManager : MonoBehaviour
{
   
   
    public static GameManager instance;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Awake()
    {
        instance = this;
    }
    // Update is called once per frame

   
}
