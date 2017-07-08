using UnityEngine;
using System.Collections;

public class TimerLevel3 : MonoBehaviour 
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
			player.GetComponent<HealthControllerLevel3>().lifeCounter--;
			timer = 20;
			player.GetComponent<HealthControllerLevel3>().Respawn();
		}
	}

	void OnGUI()
	{
		GUI.Box (new Rect(25, 120, 25, 20), "" + timer.ToString("0"), customGUIStyle);
	}
}
