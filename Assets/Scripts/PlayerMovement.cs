using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private Rigidbody2D playerRigidBody;

    private Vector2 movement;
    private Vector2 face; //Last direction moved

    public void Move(Vector2 argMovement)
    {
        movement = argMovement;
        if (movement != Vector2.zero) { face = movement; }
        playerRigidBody.MovePosition(playerRigidBody.position + (movement * moveSpeed * Time.fixedDeltaTime));
    }

    public Vector2 GetMovement() { return movement; }

    public Vector2 GetFace() { return face; }

}
