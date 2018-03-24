using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraAnimationController : MonoBehaviour {

    //declare the animator
    public Animator cameraAnim;

	// Use this for initialization
	void Start () {
        // get the component
        cameraAnim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown("a"))
        {
            cameraAnim.Play("cameraAnimationOut");
        };
		
	}
}
