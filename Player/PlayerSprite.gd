extends Sprite

const upTexture = preload("res://Player/Xenu-Up.png")
const downTexture = preload("res://Player/Xenu-Down.png")
const rightTexture = preload("res://Player/Xenu-Right.png")
const leftTexture = preload("res://Player/Xenu-Left.png")

func setSprite(velocity: Vector2) -> void:
	var newTexture: Texture
	if abs(velocity.x) > abs(velocity.y):
		if velocity.x > 0:
			newTexture = rightTexture
		else:
			newTexture = leftTexture
	elif abs(velocity.x) < abs(velocity.y):
		if velocity.y < 0:
			newTexture = upTexture
		else:
			newTexture = downTexture
	else:
		return
	self.set_texture(newTexture)
