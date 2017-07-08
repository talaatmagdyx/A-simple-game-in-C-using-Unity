using UnityEngine;
using System.Collections;

public class PlayerFreezeLevel3 : MonoBehaviour 
{
	public AudioClip introSound;

	void Start()
	{
		GetComponent<ThirdPersonController>().enabled = false;
		audio.clip = introSound;
		audio.Play();
	}

	void Update()
	{
		if(!audio.isPlaying)
		{
			GetComponent<ThirdPersonController>().enabled = true;
			GetComponent<TimerLevel3>().begin = true;
		}
	}

	public IEnumerator Spawn()
	{
		GetComponent<ThirdPersonController>().enabled = false;
		yield return new WaitForSeconds(1);
		GetComponent<ThirdPersonController>().enabled = true;
	}
}
