using UnityEngine;
using System.Collections;

public class HealthControllerLevel2 : MonoBehaviour 
{
	public Texture2D heartThree;
	public Texture2D heartTwo;
	public Texture2D heartOne;

	public int lifeCounter = 3;

	public Transform destination;
	public GameObject player;

	void OnGUI()
	{
		if(lifeCounter >= 3)
		{
			GUI.DrawTexture(new Rect(0, 0, 300, 100), heartThree);	
		}

		if(lifeCounter >= 2)
		{
			GUI.DrawTexture(new Rect(0, 0, 300, 100), heartTwo);	
		}

		if(lifeCounter <= 1)
		{
			GUI.DrawTexture(new Rect(0, 0, 300, 100), heartOne);	
		}

		if(lifeCounter == 0)
		{
			Application.LoadLevel("DeathScene2");
		}
	}

	public void Respawn()
	{
		player.transform.position = destination.position;
		player.GetComponent<PlayerFreezeLevel2>().Spawn();
		player.GetComponent<TimerLevel2>().timer = 20;
	}
}






















