using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    private const string WALKING_DIRECTION_X = "WalkingDirectionX";
    private const string WALKING_DIRECTION_Y = "WalkingDirectionY";
    private const string SPEED = "Speed";
    private Animator myAnimator;
    [SerializeField] private PlayerMovement playerMovement;


    private void Awake()
    {
        myAnimator = GetComponent<Animator>();

    }

    private void Update()
    {
        Vector2 movement = playerMovement.GetMovement();
        myAnimator.SetFloat(WALKING_DIRECTION_X, movement.x);
        myAnimator.SetFloat(WALKING_DIRECTION_Y, movement.y);
        myAnimator.SetFloat(SPEED, movement.magnitude);
    }
}
