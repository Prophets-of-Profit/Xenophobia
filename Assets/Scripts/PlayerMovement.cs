using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * The class that is attached to the player that manage their movement
 */
public class PlayerMovement : MonoBehaviour {

	public float maxSpeed = 5f;
	private Vector2 _velocity;
	private Rigidbody2D _body;

	/**
	 * Initializes all necessary variables for player movement
	 */
	public void Start() {
		this._body = this.GetComponent<Rigidbody2D>();
	}

	/**
	 * Called once per frame: checks input and then moves the player
	 */
    public void Update() {
	    this._velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
	    this._body.MovePosition(this._body.position + this.maxSpeed * Time.deltaTime * this._velocity);
    }
    
}
