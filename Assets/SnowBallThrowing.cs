using UnityEngine;
using System.Collections;

public class SnowBallThrowing : MonoBehaviour {
	private Vector3 mouseStartPos;
	private Vector3 mouseEndPos;
	private bool fire = false;
	public GameObject snowBall;
	public float speedMult = 2.0f;
	
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			mouseStartPos = Input.mousePosition;
		}
		if(Input.GetMouseButtonUp(0)){
			mouseEndPos = Input.mousePosition;
			fire = true;
		}
		if(fire){
			Fire((mouseStartPos - mouseEndPos).normalized, (mouseEndPos - mouseStartPos).magnitude);
			fire = false;
		}
	}
	
	void Fire(Vector3 direction, float speed){
		GameObject projectile = (GameObject)GameObject.Instantiate(snowBall, this.transform.position, Quaternion.identity);
		projectile.rigidbody2D.AddForce(direction * speed * speedMult);
	}
}
