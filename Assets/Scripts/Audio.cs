using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{

    [SerializeField]
    private AudioSource _audioSource;

    [SerializeField]
    private AudioClip _audioClip1;

    [SerializeField]
    private AudioClip _audioClip2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }


        if (Input.GetKeyDown(KeyCode.W))
        {
            _audioSource.clip = _audioClip1;
            _audioSource.Play();
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            _audioSource.Stop();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            _audioSource.clip = _audioClip2;
            _audioSource.Play();
        }
        if (Input.GetKeyUp(KeyCode.R))
        {
            _audioSource.Stop();
        }
    }
}
