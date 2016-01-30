using UnityEngine;
using System.Collections;

public class AcionaSuperGun : MonoBehaviour {
	
	bool ball3Ok;
	bool ball4Ok;
    public AudioClip somCracker;
    
    public void OnTriggerEnter(Collider other)
	{	
		if((other.tag == "Push"))
		{
			if(other.name == "Bola3")
				ball3Ok = true;
			if(other.name == "Bola4")
				ball4Ok = true;

            if (ball3Ok && ball4Ok)
            {
                EstadoJogo.HasPenDrive2 = true;
                AudioSource.PlayClipAtPoint(somCracker, transform.position, 1.5f);
            }
		}		
	}
}
