using UnityEngine;
using System.Collections;

public class sphere3 : MonoBehaviour 
{
	public GameObject portal;
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
		if(other.gameObject.tag == "darkness") 
		{
			print ("darkness entered sphere 3");
			portal.transform.localScale = new Vector3(1.5F, .01F, 1.5F);

			player.GetComponent<ParticleSystem>().emissionRate = 10;

			Vector3 tempPosition = new Vector3(player.transform.position.x, .6F, player.transform.position.z);
			player.transform.position = tempPosition;

			Vector3 tempPortalPosition = new Vector3(portal.transform.position.x, -.3F, portal.transform.position.z);
			portal.transform.position = tempPortalPosition;
			
		}
	}


}


