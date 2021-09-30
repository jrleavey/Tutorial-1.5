using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatController : MonoBehaviour
{

    [SerializeField]
    private AudioSource _audioSource;

    [SerializeField]
    private AudioClip _audioClip1;

    [SerializeField]
    private AudioClip _audioClip2;

    Animator _anim;
    // Start is called before the first frame update
    void Start()
    {
        _anim = GetComponent<Animator>();
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
            _anim.SetInteger("State", 1);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            _audioSource.Stop();
            _anim.SetInteger("State", 0);

        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            _audioSource.clip = _audioClip2;
            _audioSource.Play();
            _anim.SetInteger("State", 2);

        }
        if (Input.GetKeyUp(KeyCode.R))
        {
            _audioSource.Stop();
            _anim.SetInteger("State", 0);

        }
    }
}
