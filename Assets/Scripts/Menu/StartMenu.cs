using UnityEngine;
using System.Collections;

public class StartMenu : MonoBehaviour 
{
	public bool quitButton = false; //Quitbutton boolean 
	public GameObject button; //The button we want to set for each menu element

	public Material normalTex; //Normal material for our buttons
	public Material hoverTex; //hover material for our buttons

	public AudioClip clickSound; //audio clip clicksound

	void Start()
	{
		button.renderer.material = normalTex; //Setting the button material at the game start to our normal texture
	}

	void OnMouseEnter() //When your mouse enters a collider - Namely a button
	{
		audio.PlayOneShot(clickSound); //Play a sound once everytime we enter the button
		button.renderer.material = hoverTex; //Make sure the texture changes to the hover texture
	}

	void OnMouseExit() //when your mouse exits the collider - Namely a button
	{
		audio.Stop (); //Stop the audio that was playing
		button.renderer.material = normalTex; //Change the material back to the normal texture
	}

	void OnMouseUp() //When you click with your mouse and you let go of the mouse press
	{
		if(quitButton) //If the quitbutton equals true then well use application.quit - meaning the application will quit if built.
		{
			Application.Quit();
		}

		else
		{
			Application.LoadLevel ("Level1"); //if not then we will load the level1 application
		}
	}
}












