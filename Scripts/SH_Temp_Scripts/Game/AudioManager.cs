using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource audioSource;
    private static AudioManager _instance;
    public static AudioManager Instance
    {
        get
        {
            if(_instance == null)
            {
                _instance = FindObjectOfType<AudioManager>();
                if (_instance == null)
                {
                    AudioManager singletonObject = new AudioManager();
                    _instance = singletonObject.AddComponent<AudioManager>();
                    singletonObject.name = typeof(AudioManager).ToString() + "(Singleton)";

                    DontDestroyOnLoad(singletonObject);
                }
            }
            return _instance;
        }
    }

    private void Awake()
    {
        if(_instance == null) 
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if(_instance != this) 
        {
            Destroy(gameObject);
        }
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    public void PlaySound(AudioSource _audioSource)
    {
        AudioClip clip = _audioSource.clip;
        audioSource.clip = clip;
        audioSource.Play();
    }
}
