using UnityEngine;
using System.Collections;

public class CameraColisao : MonoBehaviour {

    public SimpleSmoothMouseLook cameraSmooth;
	
    public void OnTriggerStay(Collider other)
    {
        if(other.tag == "ColisaoCam")
            cameraSmooth.NaoTemColisao = false;
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.tag == "ColisaoCam")
            cameraSmooth.NaoTemColisao = true;
    }
}
