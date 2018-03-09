using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class AnimatorBehaviour : MonoBehaviour {
	private Animator animator;

	[SerializeField] private string Blink;
	[Range(2f, 10.0f)]
	[SerializeField] private float maxRandom;
	[Range(0f, 2f)]
	[SerializeField] private float minRandom;

	private void Awake() {
		animator = GetComponent<Animator>();
	}

	// Use this for initialization
	void Start () {
		StartCoroutine(PlayAnimation());
	}
	
	private IEnumerator PlayAnimation(){
		float rndTimer;
		do{
			rndTimer = Random.Range(minRandom, maxRandom);

			yield return new WaitForSeconds(rndTimer);
		
			animator.SetTrigger(Blink);
		}while(true);
	}
}
