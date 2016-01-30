using UnityEngine;
using System.Collections;

/* 
 * Released under the creative commons attribution license.
 * Do whatever you like with the code, just give credit to Stuart Spence.
 * https://creativecommons.org/licenses/by/3.0/
 */

public class Portal : MonoBehaviour
{
    private Vector3 portalNormal = new Vector3();
    
    public Portal otherPortal;
    public GameObject player;
	public MudaCamera _mudaCam;
	
    public AudioClip teleportSound;
    public bool hasMoved = false;

    //this portal is temporarily disabled when there is time left on the disableTimer - when it is greater than zero.
    float disableTimer = 0;

    void Start()
    { 
    
    }
    
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject == player && disableTimer <= 0 && hasMoved && otherPortal.hasMoved)
            otherPortal.MovePlayerToThisPortal();
    }

    void Update()
    {
        if (disableTimer > 0)
            disableTimer -= Time.deltaTime;
    }   

    public void MovePlayerToThisPortal()
    {
        disableTimer = 1;
   
        //set the player position to just in front of the portal.
        Vector3 exitPosition = transform.position + otherPortal.portalNormal * 2;
        player.transform.position = exitPosition;
      
        //play the teleport sound
		AudioSource.PlayClipAtPoint(teleportSound, transform.position, 0.6f);
		
		if(_mudaCam != null)
			_mudaCam.MudaCameraScript();
    }
}
