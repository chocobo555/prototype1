using UnityEngine;
using System.Collections;

public class DarknessAdvance : MonoBehaviour 
{
	public GameObject player;

	public float speed;

	
	// Use this for initialization
	void Start () 
	{
	
	}


	// Update is called once per frame
	void Update () 
	{
		transform.position = Vector3.MoveTowards (transform.position, player.transform.position, speed * Time.deltaTime);
	}

}
