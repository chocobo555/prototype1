using UnityEngine;
using System.Collections;

public class sphere2 : MonoBehaviour 
{
	public sphere1 mySphere1;
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

			if (beenEntered == true && mySphere1.beenEntered == false) 
			{
				mySphere1.beenEntered = false;
				mySphere3.beenEntered = false;

				print ("darkness entered sphere 2");
				portal.transform.localScale = new Vector3(2.5F, .01F, 2.5F);
				
				player.GetComponent<ParticleSystem>().emissionRate = 15;
				
				player.GetComponent<MeshRenderer>().materials[0].color = myColor;

				player.GetComponent<movement>().speed = 10;
				player.GetComponent<movement>().rotSpeed = 20;
				
				Vector3 tempPosition = new Vector3(player.transform.position.x, .25F, player.transform.position.z);
				player.transform.position = tempPosition;
				
				Vector3 tempPortalPosition = new Vector3(portal.transform.position.x, .01F, portal.transform.position.z);
				portal.transform.position = tempPortalPosition;
			}
		}
	}



}
