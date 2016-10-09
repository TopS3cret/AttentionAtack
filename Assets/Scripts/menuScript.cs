using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class menuScript : MonoBehaviour {

	public Canvas exitMenu;
	public Button test;
	public Button play;
	public Button exit;

	// Use this for initialization
	void Start () {
		exitMenu = exitMenu.GetComponent<Canvas> ();
		test = test.GetComponent<Button> ();
		play = play.GetComponent<Button> ();
		exit = exit.GetComponent<Button> ();
		exitMenu.enabled = false;
	}

	public void ExitPress()
	{
		exitMenu.enabled = true;
		test.enabled = false;
		play.enabled = false;
		exit.enabled = false;
	}

	public void NoPress() 
	{
		exitMenu.enabled = false;
		test.enabled = true;
		play.enabled = true;
		exit.enabled = true;
	}

	public void StartTest()
	{
		SceneManager.LoadScene ("ADHDTest.unity");
	}

	public void StartGame()
	{
		SceneManager.LoadScene ("Laser.unity");
	}

	public void ExitGame()
	{
		Application.Quit ();
	}


}
