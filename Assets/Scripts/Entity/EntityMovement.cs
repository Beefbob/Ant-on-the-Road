using UnityEngine;

public class EntityMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private Rigidbody2D myRigidBody;

    private Vector2 movement;
    private Vector2 face; //Last direction moved

    /// <summary>
    /// Moves the entity by the given Vector2 movement amount.
    /// Also sets the entity's last movement direction.
    /// </summary>
    public void MoveDirection(Vector2 argMovement)
    {
        movement = argMovement;
        if (movement != Vector2.zero) { face = movement; }
        myRigidBody.MovePosition(myRigidBody.position + (movement * moveSpeed * Time.fixedDeltaTime));
    }

    public void MoveTo(Vector2 argMovement)
    {
        movement = argMovement;
        if (movement != Vector2.zero) { face = movement; }
        myRigidBody.MovePosition(myRigidBody.position + (movement * moveSpeed * Time.fixedDeltaTime));
        Debug.Log("Body Position: " + myRigidBody.position);
    }

    /// <summary>
    /// Returns vector2 of entity current movement
    /// </summary>
    public Vector2 GetMovementNormalized() { return movement.normalized; }

    /// <summary>
    /// Returns Vector2 of the entity's last moved direction
    /// </summary>
    public Vector2 GetFace() { return face; }

    public float GetMoveSpeed() { return moveSpeed; }

    public Vector2 GetPosition() { return myRigidBody.position; }
}
