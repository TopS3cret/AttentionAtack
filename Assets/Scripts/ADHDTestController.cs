using UnityEngine;
using System.Collections;

public class ADHDTestController : MonoBehaviour {
	public static ADHDTestController Instance;
	public enum Difficulty {
		EASY,
		MEDIUM,
		HARD
	}

	public BoxCollider2D Border;
	public AttentionWhoreController AttentionWhore;

	public Difficulty UserDifficulty;

	// Use this for initialization
	void Start () {
		Instance = this;
		UserDifficulty = Difficulty.EASY;
		AttentionWhore.SetRandomPosition (Border.bounds.extents.x, Border.bounds.extents.y);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void IncreaseDifficulty(){
		if (UserDifficulty == Difficulty.EASY) {
			UserDifficulty = Difficulty.MEDIUM;
		} else {
			UserDifficulty = Difficulty.HARD;
		} 
	}
}
