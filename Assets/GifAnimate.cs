using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GifAnimate : MonoBehaviour {

	public Sprite[] frames;
	public int framesPerSecond = 10;
	
	void Update() 
	{	
		int index = (int)((Time.time * framesPerSecond) % frames.Length);
		GetComponent<Image>().overrideSprite = frames[index];
	}
}
