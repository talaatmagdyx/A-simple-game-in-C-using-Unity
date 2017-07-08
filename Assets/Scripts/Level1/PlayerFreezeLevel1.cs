using UnityEngine;
using System.Collections;

public class PlayerFreezeLevel1 : MonoBehaviour 
{
	public AudioClip introSound; //Apply the audioclip to the inspector called introsound

	void Start() //Starts when the game starts
	{
		GetComponent<ThirdPersonController>().enabled = false; //Get component "ThirdPersonController" to disable it.
		audio.clip = introSound; //Look for the audio clip "intro sound"
		audio.Play(); //Play the audio
	}

	void Update() //Run this function every frame
	{
		if(!audio.isPlaying) //if audio isn't playing 
		{
			GetComponent<ThirdPersonController>().enabled = true; //Find component "ThirdPersonController" and enable it
			GetComponent<TimerLevel1>().begin = true; //Find component "TimerLevel1" and set the begin bool to true
		}
	}

	public IEnumerator Spawn() //Public function spawn as a IEnumerator type so we can use a yield statement.
	{
		GetComponent<ThirdPersonController>().enabled = false;
		yield return new WaitForSeconds(1); //Waits 1 second until moving onto the next line
		GetComponent<ThirdPersonController>().enabled = true;
	}
}
