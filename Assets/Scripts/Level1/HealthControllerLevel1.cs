using UnityEngine;
using System.Collections;

public class HealthControllerLevel1 : MonoBehaviour 
{
	public Texture2D heartThree; //Three textures to hold the hearts
	public Texture2D heartTwo;
	public Texture2D heartOne;

	public int lifeCounter = 3; // Counter for life

	public Transform destination; //The respawn position, as Transform - Meaning it allows movement of the player
	public GameObject player; //Finding our player object

	void OnGUI() //Showing some on screen
	{
		if(lifeCounter >= 3) //lifeCounter is greater than or equal to 3
		{
			GUI.DrawTexture(new Rect(0, 0, 300, 100), heartThree); //Draw a texture in a rectangle, 0 on the x, 0 on the y and 300 width, 100 height.
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
			Application.LoadLevel("DeathScene1");
		}
	}

	public void Respawn() //Our public respawn function
	{
		player.transform.position = destination.position; //Moves the player from it's position to the destinations position
		player.GetComponent<PlayerFreezeLevel1>().Spawn(); //Finds the component "PlayerFreezeLevel1" and looks for the function "Spawn" and executes its code
		player.GetComponent<TimerLevel1>().timer = 20; //Finds the component "TimerLevel1" and finds the variable timer and sets it equal to 20!
	}
}






















