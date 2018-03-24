using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zAxisAnimationController : MonoBehaviour {

    public Animator armAnim;

    // testing for sounds
    public AudioClip musicClip;
    public AudioSource musicSource;

	// Use this for initialization
	void Start () {

        armAnim = GetComponent<Animator>();

        // testing 
        musicSource.clip = musicClip;
        
	}
	
	// Update is called once per frame
	void Update () {
	
        if (Input.GetKeyDown("z"))
        {
            armAnim.Play("zAxisAnimation_out");

            // testing
            musicSource.Play();
          
        };
        
	}
}
