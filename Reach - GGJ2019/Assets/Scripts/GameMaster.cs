using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
public class GameMaster : MonoBehaviour
{
  //  public AudioSource main;
 //   public AudioSource spatial;
 //   public AudioClip mainMusic;
    public static GameMaster instance;
    public Vector3 lastCheckpointPos;
    private void Start()
    {

        //StartCoroutine(FadeInMusic());
        //float musictime = PlayerPrefs.GetFloat("AudioTime", 0);
        //  main.clip = mainMusic;
        // main.time = musictime;
        // main.Play();
    }

    // public void setTime()
    // {
    //     PlayerPrefs.SetFloat("AudioTime", main.time);
    // }

    private void Awake()
    {


        if (instance == null)
        {

            instance = this;
            DontDestroyOnLoad(this);
        }
        // Destroy(gameObject);
    }
}
    
   // public void IncreaseSpatial(bool exchange)
   // {
    //    Debug.Log("got this far");
    //    StartCoroutine(SwitchVolumes(exchange));
   // }
  //  public IEnumerator SwitchVolumes(bool mainSound)
 //   {

      ///  float t = 0;
      //  float time = 3f;
      //  while (t <= 1f)
       // {
          //  t += Time.deltaTime / time;

            //main.volume = mainSound ? t : 1f - t;
           // spatial.volume = mainSound ? 1f - t : t;

           // yield return null;
       // }

   // }
   // public IEnumerator FadeInMusic()
    //{
      //  float t = 0;
       // float time = 3f;
       // while (t <= 1f)
        //{
          //  t += Time.deltaTime / time;

        //    main.volume = t;
           

      //      yield return null;
    //    }
  //  }


//}
