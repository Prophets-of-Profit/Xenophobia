using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * A camera that LERPs to its target to follow the target smoothly
 */
public class CameraFollow : MonoBehaviour {
	
	//The target that this camera should follow
	public Transform target;

	//How fast the camera catches up to the target
	public float smoothing;
	
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

		Vector2 newPosition = Vector2.Lerp(selfPosition, targetPosition, this.smoothing);
		this.transform.position = new Vector3(newPosition.x, newPosition.y, this.transform.position.z);

	}
	
}
