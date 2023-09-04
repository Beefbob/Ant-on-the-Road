using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private Rigidbody2D playerRigidBody;

    private bool isPlayerWalking = false;
    private Vector2 movement;

    public void GetInput()
    {
        movement = Vector2.zero;
        if (Input.GetKey(KeyCode.W)) { movement.y = 1; }
        if (Input.GetKey(KeyCode.S)) { movement.y = -1; }
        if (Input.GetKey(KeyCode.A)) { movement.x = -1; }
        if (Input.GetKey(KeyCode.D)) { movement.x = 1; }
        Debug.Log(movement.ToString());
        isPlayerWalking = movement != Vector2.zero;
    }

    public void ProcessInput()
    {
        movement.Normalize();
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
