using UnityEngine;
using System.Collections;

public class Sabina : MonoBehaviour {
	private bool facingRight = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("up")) {
			print ("up arrow key is held up");
			(GetComponent<Animator> ()).SetBool ("isAgachada", false);
			(GetComponent<Animator> ()).SetBool ("isParada", true);
		}

		if (Input.GetKey ("down")) {
			(GetComponent<Animator> ()).SetBool ("isParada", false);
			(GetComponent<Animator> ()).SetBool ("isAgachada", true);
			print ("down arrow key is held down");
		}

		if (Input.GetKey ("left")) {
			
			transform.position -= new Vector3(0.05f,0,0);

			(GetComponent<Animator> ()).SetBool ("isCaminando", true);

		}

		if (Input.GetKey ("right")) {
			
			transform.position += new Vector3(0.05f,0,0);

			(GetComponent<Animator> ()).SetBool ("isCaminando", true);

		}

		if (Input.GetKey ("return")) {
			(GetComponent<Animator> ()).SetBool ("isParada", true);
			(GetComponent<Animator> ()).SetBool ("isBrincando", true);
			print ("down arrow key is held enter");
		}
	}
}
