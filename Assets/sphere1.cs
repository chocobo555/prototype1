using UnityEngine;
using System.Collections;

public class sphere1 : MonoBehaviour 
{
	public sphere2 mySphere2;
	public sphere3 mySphere3;

	public bool beenEntered = false;

	public GameObject portal;
	public GameObject player;

	public Color myColor; // .5, .5, .5, 1  is grey

	
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "darkness") 
		{
			beenEntered = true;

			if(beenEntered == true) 
			{
				mySphere3.beenEntered = false;
				mySphere2.beenEntered = false;

				print ("darkness entered sphere 1");
				portal.transform.localScale = new Vector3(3.5F, .01F, 3.5F);
				
				player.GetComponent<ParticleSystem>().emissionRate = 20;
				
				player.GetComponent<MeshRenderer>().materials[0].color = myColor;

				player.GetComponent<movement>().speed = 5;
				player.GetComponent<movement>().rotSpeed = 10;
				
				Vector3 tempPosition = new Vector3(player.transform.position.x, -.3F, player.transform.position.z);
				player.transform.position = tempPosition;
				
				Vector3 tempPortalPosition = new Vector3(portal.transform.position.x, .01F, portal.transform.position.z);
				portal.transform.position = tempPortalPosition;
			}
		}
	}



}
