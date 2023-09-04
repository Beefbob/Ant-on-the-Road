using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private Rigidbody2D playerRigidBody;

    private bool isPlayerWalking = false;
    private Vector2 movement;

    public void Move(Vector2 argMovement)
    {
        movement = argMovement;
        isPlayerWalking = movement != Vector2.zero;
        playerRigidBody.MovePosition(playerRigidBody.position + (movement * moveSpeed * Time.fixedDeltaTime));
    }

    public Vector2 GetMovement()
    {
        return movement;
    }
    public bool IsWalking()
    {
        return isPlayerWalking;
    }
}
