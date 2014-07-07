using UnityEngine;
using System.Collections;

public class PlayerControllerScript : MonoBehaviour {
	public float maxSpeed = 10f;
	Animator anim;

	void Start () {
		anim = GetComponent<Animator>();
	}

	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis("Horizontal");
		anim.SetFloat("Speed", Mathf.Abs(moveHorizontal));
		rigidbody2D.velocity = new Vector2(moveHorizontal * maxSpeed, rigidbody2D.velocity.y);
	}
}
