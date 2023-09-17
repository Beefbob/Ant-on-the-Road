using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] private GameInput gameInput;
    [SerializeField] private PlayerMovement playerMovement;
    private void Update()
    {
        Vector2 inputVector = gameInput.GetMovementVectorNormalized();
        playerMovement.Move(inputVector);
    }
}
