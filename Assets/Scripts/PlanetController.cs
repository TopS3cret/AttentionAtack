using UnityEngine;
using System.Collections;

public class PlanetController : MonoBehaviour {
	public ParticleSystem Explosion;
	public bool BadPlanet;
	public bool Spawned { get; set; }

	// Use this for initialization
	void Start () {
        Spawned = true;
	}

	// Update is called once per frame
	void Update () {

	}

	public void PlayExplosion() {
		Explosion.Play ();
	}

	public void Despawn(){
	    Spawned = false;
	}
}
