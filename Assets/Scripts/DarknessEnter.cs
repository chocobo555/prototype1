using UnityEngine;
using System.Collections;

public class DarknessEnter : MonoBehaviour
{

	public GameObject player;


	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player") 
		{
	
			player.GetComponent<movement>().speed = 5;

		}
	}

}



