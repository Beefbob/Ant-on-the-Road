using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] private GameInput gameInput;
    [SerializeField] public EntityMovement entityMovement;
    private void Update()
    {
        Vector2 inputVector = gameInput.GetMovementVectorNormalized();
        entityMovement.MoveDirection(inputVector);
    }


}
