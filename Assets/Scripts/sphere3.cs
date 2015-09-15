using UnityEngine;
using System.Collections;

public class sphere3 : MonoBehaviour 
{
	public sphere1 mySphere1;
	public sphere2 mySphere2;

	public bool beenEntered = false;

	public GameObject portal;
	public GameObject player;

	public Color myColor; // .5, .5, .5, 1  is grey


	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "darkness") 
		{
			beenEntered = true;

			if(beenEntered = true && mySphere1.beenEntered == false && mySphere2.beenEntered == false) 
			{
				print ("darkness entered sphere 3");
				portal.transform.localScale = new Vector3(1.5F, .01F, 1.5F);
				
				player.GetComponent<ParticleSystem>().emissionRate = 10;
				
				player.GetComponent<MeshRenderer>().materials[0].color = myColor;

				player.GetComponent<movement>().speed = 15;
				player.GetComponent<movement>().rotSpeed = 30;
				
				Vector3 tempPosition = new Vector3(player.transform.position.x, .6F, player.transform.position.z);
				player.transform.position = tempPosition;
				
				Vector3 tempPortalPosition = new Vector3(portal.transform.position.x, .01F, portal.transform.position.z);
				portal.transform.position = tempPortalPosition;
			}
		}		
	}
}


