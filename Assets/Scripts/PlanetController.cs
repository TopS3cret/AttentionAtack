using UnityEngine;
using System.Collections;

public class PlanetController : MonoBehaviour {
	public ParticleSystem Explosion;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void PlayExplosion() {
		Explosion.Play ();
	}
}
