using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    private const string WALKING_DIRECTION_X = "FaceX";
    private const string WALKING_DIRECTION_Y = "FaceY";
    private const string SPEED = "Speed";
    private Animator myAnimator;
    [SerializeField] private PlayerMovement playerMovement;


    private void Awake()
    {
        myAnimator = GetComponent<Animator>();

    }

    private void Update()
    {
        Vector2 face = playerMovement.GetFace();
        Debug.Log(face.x + " " + face.y);
        myAnimator.SetFloat(WALKING_DIRECTION_X, face.x);
        myAnimator.SetFloat(WALKING_DIRECTION_Y, face.y);
        myAnimator.SetFloat(SPEED, playerMovement.GetMovement().magnitude);
    }
}
