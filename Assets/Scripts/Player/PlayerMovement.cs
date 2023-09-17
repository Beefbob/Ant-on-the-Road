using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private Rigidbody2D playerRigidBody;

    private Vector2 movement;
    private Vector2 face; //Last direction moved

    /// <summary>
    /// Moves the player by the given Vector2 movement amount.
    /// Also sets the player's last movement direction.
    /// </summary>
    public void Move(Vector2 argMovement)
    {
        movement = argMovement;
        if (movement != Vector2.zero) { face = movement; }
        playerRigidBody.MovePosition(playerRigidBody.position + (movement * moveSpeed * Time.fixedDeltaTime));
    }

    /// <summary>
    /// Returns vector2 of players current movement
    /// </summary>
    public Vector2 GetMovement() { return movement; }

    /// <summary>
    /// Returns Vector2 of the player's last moved direction
    /// </summary>
    public Vector2 GetFace() { return face; }

}
