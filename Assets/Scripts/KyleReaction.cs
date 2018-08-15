using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KyleReaction : MonoBehaviour {

	Animator anim;
	public AudioSource sound;

	void Start()
	{
		anim = GetComponent<Animator> ();
	}

    private void OnMouseDown()
    {
        if (Input.GetMouseButton(0))
            Reaction();
    }

	public void Reaction()
	{
		anim.Play("Knock");
		sound.Play();
	}

}
