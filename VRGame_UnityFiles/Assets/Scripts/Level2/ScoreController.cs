using UnityEngine;
using System.Collections;

public class ScoreController : MonoBehaviour 
{
	public bool redCube = false;
	public bool purpleCube = false;
	public bool blueCube = false;
	public bool greenCube = false;

	public GameObject endCollider;
	public GameObject door;

	public Material greenDoor;

	void Update()
	{
		if(redCube == true && purpleCube == true && blueCube == true && greenCube == true)
		{
			endCollider.active = true;
			door.GetComponent<Renderer>().material = greenDoor;
		}
	}
}
