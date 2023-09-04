using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] private GameInput gameInput;
    [SerializeField] private PlayerMovement playerMovement;
    private void Update()
    {
        playerMovement.GetInput();

    }

    private void FixedUpdate()
    {
        playerMovement.ProcessInput();
    }


}
