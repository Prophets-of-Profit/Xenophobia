using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * A camera that SmoothDamps to its target to follow the target smoothly
 */
public class CameraFollow : MonoBehaviour {
	
	//The target that this camera should follow
	public Transform target;
	
	//How much time it takes the camera to reach the player
	public float smoothTime = 0.125f;

	//How fast this camera is moving
	private Vector2 _velocity;
	
	/**
	 * Moves closer to target if necessary
	 */
	public void LateUpdate() {
		
		Vector2 selfPosition = new Vector2(this.transform.position.x, this.transform.position.y);
		Vector2 targetPosition = new Vector2(this.target.position.x, this.target.position.y);
		
		//If the camera is at the target already, do nothing
		if (selfPosition == targetPosition) {
			return;
		}

		Vector2 newPosition = Vector2.SmoothDamp(selfPosition, targetPosition, ref this._velocity, this.smoothTime);
		this.transform.position = new Vector3(newPosition.x, newPosition.y, this.transform.position.z);

	}
	
}
