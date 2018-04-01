using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    bool locked= true;
    bool doorOpen;
	private Animator animator;

	private AudioSource audioSource;

	void Start() {
		doorOpen = false;
		audioSource = GetComponent<AudioSource>();
		animator = GetComponent<Animator> ();

	}

	void onTriggerEnter(Collider other) {
		if (other.gameObject.tag == "Player") {
			AudioSource.PlayClipAtPoint(audioSource.clip, transform.position);
			Debug.Log("Trigger collided with the player:door");
			doorOpen = true;
			Doors ("Open");

		}

	}

	void Doors(string direction) {
		animator.SetTrigger(direction);
	}





}
