using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KyleReaction : MonoBehaviour {

	Animator anim;
	string URL;
	public AudioSource sound;

	void Start()
	{
		anim = GetComponent<Animator> ();
		URL = "linkedin.com/in/lunavi97";
	}

	void Update()
	{
		if (Input.GetMouseButtonDown (0)) {
			Reaction();
		}
	}

	public void Reaction()
	{
		anim.Play("Golpe");
		sound.Play();
	}

	public void GoToURL()
	{
		Application.OpenURL(URL);
	}

}
