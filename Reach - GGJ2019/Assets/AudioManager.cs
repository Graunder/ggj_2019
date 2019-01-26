using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class AudioManager : MonoBehaviour
{
    public AudioSource mainSource;
    public AudioClip mainClip;
    public AudioClip theme;
   
   
    public static AudioManager instance;

    private void Start()
    {
        float musictime = PlayerPrefs.GetFloat("AudioTime", 0);
        mainClip = mainSource.clip;
        mainSource.time = musictime;
        
        if (musictime == 0)
        {
            StartCoroutine(FadeInMusic());
            Debug.Log("Playing");
            mainSource.Play();
        }else
        {
            StartCoroutine(FadeInMusic());

        }


    }

    public void setTime()
    {
        PlayerPrefs.SetFloat("AudioTime", mainSource.time);
    }

    private void Awake()
    {


        if (instance == null)
        {
            PlayerPrefs.DeleteKey("AudioTime");
            instance = this;
            DontDestroyOnLoad(this);
        }



        // Destroy(gameObject);



    }

    private void OnApplicationQuit()
    {
        PlayerPrefs.DeleteAll();
    }

    public void IncreaseSpatial(bool exchange)
    {
        Debug.Log("got this far");
        StartCoroutine(SwitchVolumes(exchange));
    }
    public IEnumerator SwitchVolumes(bool mainSound)
    {

        float t = 0;
        float time = 3f;
        while (t <= 1f)
        {
            t += Time.deltaTime / time;

            mainSource.volume = mainSound ? t : 1f - t;
         //   spatial.volume = mainSound ? 1f - t : t;

            yield return null;
        }

    }
    public IEnumerator FadeInMusic()
    {
        float t = 0;
        float time = 3f;
        while (t <= 1f)
        {
            t += Time.deltaTime / time;

            mainSource.volume = t;


            yield return null;
        }
    }

}
