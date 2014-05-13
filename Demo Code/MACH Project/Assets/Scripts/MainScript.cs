using UnityEngine;
using System.Collections;

public class MainScript : MonoBehaviour {

	public GameObject BoxGameObject;

	// Use this for initialization
	void Start () {
	
		Instantiate(BoxGameObject, new Vector3(0,3,1), Quaternion.identity);
		Instantiate(BoxGameObject, new Vector3(1,2,0), Quaternion.identity);
		Instantiate(BoxGameObject, new Vector3(2,3,0), Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
