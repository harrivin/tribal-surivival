using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HeroControls : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		// ("Move", 0.1f, 0.1f);	

	}

	// Update is called once per frame
	void Update () 
	{

		Vector2 dir = Vector2.zero;

		if (Input.GetKey (KeyCode.RightArrow) || Input.GetKey (KeyCode.LeftArrow) || Input.GetKey (KeyCode.UpArrow) || Input.GetKey (KeyCode.DownArrow))
			gameObject.GetComponent<Animator> ().speed = 1;
		else	gameObject.GetComponent<Animator> ().speed = 0;

		if (Input.GetKey (KeyCode.RightArrow) && Input.GetKey (KeyCode.UpArrow)) {
			dir += (Vector2.right) + (Vector2.up);

			gameObject.GetComponent<Animator> ().Play ("back right");
		}
		else if (Input.GetKey (KeyCode.LeftArrow) && Input.GetKey (KeyCode.UpArrow)) {
				dir += (-Vector2.right) + (Vector2.up);
			gameObject.GetComponent<Animator> ().Play ("back left");
		}
		else if (Input.GetKey (KeyCode.DownArrow) && Input.GetKey (KeyCode.RightArrow)) {
			dir += (-Vector2.up) + (Vector2.right);
			gameObject.GetComponent<Animator> ().Play ("forward right");
		}
		else if (Input.GetKey (KeyCode.DownArrow) && Input.GetKey (KeyCode.LeftArrow)) {
			dir += (-Vector2.up) + (-Vector2.right) ;
			gameObject.GetComponent<Animator> ().Play ("forward left");
		} 

		else if (Input.GetKey (KeyCode.RightArrow)) {
			dir += (Vector2.right);
			gameObject.GetComponent<Animator> ().Play ("WalkRight");
		}
		else if (Input.GetKey (KeyCode.LeftArrow)) {
			dir += (-Vector2.right);
			gameObject.GetComponent<Animator> ().Play ("WalkLeft");
		}
		else if (Input.GetKey (KeyCode.UpArrow)) {
			dir += (Vector2.up);
			gameObject.GetComponent<Animator> ().Play ("Walkback");
		}
		else if (Input.GetKey (KeyCode.DownArrow)) {
			dir += (-Vector2.up);
			gameObject.GetComponent<Animator> ().Play ("WalkForward");
		} 

		transform.Translate (dir);

		/*if (Input.GetKeyDown (KeyCode.R)) 
		{
			SceneManager.LoadScene("snake game");

		}
		*/
	}
}
