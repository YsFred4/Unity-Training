using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	public float moveSpeed = 10;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		float fwd = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
		float side = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;

		transform.Translate(side, 0, fwd);
	}
}
