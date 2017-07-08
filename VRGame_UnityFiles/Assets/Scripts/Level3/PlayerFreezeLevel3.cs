using UnityEngine;
using System.Collections;

public class PlayerFreezeLevel3 : MonoBehaviour 
{
	public AudioClip introSound;

	void Start()
	{
		GetComponent<ThirdPersonController>().enabled = false;
		GetComponent<AudioSource>().clip = introSound;
		GetComponent<AudioSource>().Play();
	}

	void Update()
	{
		if(!GetComponent<AudioSource>().isPlaying)
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
