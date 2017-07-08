using UnityEngine;
using System.Collections;

public class ScoreController : MonoBehaviour 
{
	public bool redCube = false; //Booleans for each colour
	public bool purpleCube = false;
	public bool blueCube = false;
	public bool greenCube = false;

	public GameObject endCollider; //End collider gameobject
	public GameObject door; //door gameobject

	public Material greenDoor; //material with name greendoor

	void Update()
	{
		if(redCube == true && purpleCube == true && blueCube == true && greenCube == true) //Checking to see if all booleans are equal to true
		{
			endCollider.active = true; //Making sure endcollider is active and true, so we can use it!
			door.renderer.material = greenDoor; //changing the material on the door object to our green material
		}
	}
}
