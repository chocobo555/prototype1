﻿using UnityEngine;
using System.Collections;

public class Shine : MonoBehaviour 
{
	public LayerMask myLayerMask;
	RaycastHit hit;

	

	// Use this for initialization
	void Start () 
	{
		gameObject.GetComponent<Light>().enabled = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKey(KeyCode.Space)) 
		{
			gameObject.GetComponent<Light>().enabled = true; 
		}
		else 
		{
			gameObject.GetComponent<Light>().enabled = false; 
		}

		if (Physics.Raycast(transform.position, transform.forward, out hit, myLayerMask) && Input.GetKey(KeyCode.Space)) 
		{
			print("hit something " + hit.collider.gameObject.name);

			if (hit.collider.gameObject.tag == "darkness") 
			{
				print ("raycast hit darkness");

				hit.collider.gameObject.GetComponent<DarknessAdvance>().speed = 0;
			}

			if (hit.collider.gameObject.tag == "Player") 
			{
				print ("raycast hit player");

				hit.collider.gameObject.GetComponent<RecieveLight>().Default();
			}
		}
	}


}




