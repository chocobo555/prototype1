using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour 
{
	public float rotSpeed;
	public float speed;


	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		float myTranslation = Input.GetAxis("Vertical") * speed;
		float myRotation = Input.GetAxis("Horizontal") * rotSpeed;

		myTranslation *= Time.deltaTime;
		myRotation *= Time.deltaTime;

		transform.Translate(0, 0, myTranslation);
		transform.Rotate(0, myRotation, 0);

	}
}
