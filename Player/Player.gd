extends KinematicBody2D

const MAX_SPEED = 750
var movementVelocity: Vector2 = Vector2(0, 0)

func _physics_process(delta: float) -> void:
	move_and_slide(movementVelocity)

func _input(event):
	movementVelocity = Vector2(Input.get_action_strength("move_right") - Input.get_action_strength("move_left"), Input.get_action_strength("move_down") - Input.get_action_strength("move_up"))
	movementVelocity *= MAX_SPEED
	if movementVelocity.length_squared() > pow(MAX_SPEED, 2):
		movementVelocity = movementVelocity.normalized() * MAX_SPEED
	get_node("PlayerSprite").setSprite(movementVelocity)
