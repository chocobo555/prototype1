using UnityEngine;
using System.Collections;

public class RecieveLight : MonoBehaviour 
{

	public GameObject portal;

	public sphere1 mySphere1;
	public sphere2 mySphere2;
	public sphere3 mySphere3;


	public void Default()
	{
		mySphere1.beenEntered = false;
		mySphere2.beenEntered = false;
		mySphere3.beenEntered = false;

		portal.transform.localScale = new Vector3(0F, .01F, 0F);
		
		gameObject.GetComponent<ParticleSystem>().emissionRate = 0;
		
		gameObject.GetComponent<MeshRenderer>().materials[0].color = Color.white;
		
		gameObject.GetComponent<movement>().speed = 20;
		gameObject.GetComponent<movement>().rotSpeed = 40;
		
		Vector3 tempPosition = new Vector3(gameObject.transform.position.x, 1F, gameObject.transform.position.z);
		gameObject.transform.position = tempPosition;
		
		Vector3 tempPortalPosition = new Vector3(portal.transform.position.x, .01F, portal.transform.position.z);
		portal.transform.position = tempPortalPosition;
	}
}
