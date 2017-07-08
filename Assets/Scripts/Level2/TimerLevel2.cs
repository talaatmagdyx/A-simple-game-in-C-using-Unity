using UnityEngine;
using System.Collections;

public class TimerLevel2 : MonoBehaviour 
{
	public float timer = 20.0f;
	public GameObject player;

	public GUIStyle customGUIStyle;
	
	public bool begin = false;
	
	void Update()
	{
		if(begin == true)
		{
			timer -= Time.deltaTime;
		}

		if(timer <= 0)
		{
			player.GetComponent<HealthControllerLevel2>().lifeCounter--;
			timer = 20;
			player.GetComponent<HealthControllerLevel2>().Respawn();
		}
	}

	void OnGUI()
	{
		GUI.Box (new Rect(25, 120, 25, 20), "" + timer.ToString("0"), customGUIStyle);
	}
}
