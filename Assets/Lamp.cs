using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class Lamp : MonoBehaviour {
	public Renderer skyboxT;
	public Renderer skyboxB;

	public Material sky1T;
	public Material sky1B;

	public Material sky2T;
	public Material sky2B;

	public Material sky3T;
	public Material sky3B;

	public Material sky4T;
	public Material sky4B;

	private int currentSky = 0;
	
	void Start () {
	}
	
	public void rubLamp() {
		GetComponent<ParticleSystem>().Emit(10); 
	}

	public void stareAtLamp() {
		switch (currentSky) {
		case 0:
			skyboxT.material = sky2T;
			skyboxB.material = sky2B;
			currentSky++;
			break;
		case 1:
			skyboxT.material = sky3T;
			skyboxB.material = sky3B;
			currentSky++;
			break;
		case 2:
			skyboxT.material = sky4T;
			skyboxB.material = sky4B;
			currentSky++;
			break;
		case 3:
			skyboxT.material = sky1T;
			skyboxB.material = sky1B;
			currentSky = 0;
			break;
		}
	}
}