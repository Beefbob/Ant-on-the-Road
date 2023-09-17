using UnityEngine;

public class EntityAnimator : MonoBehaviour
{
    private const string WALKING_DIRECTION_X = "FaceX";
    private const string WALKING_DIRECTION_Y = "FaceY";
    private const string SPEED = "Speed";
    private Animator animator;
    [SerializeField] private EntityMovement entityMovement;

    /// <summary>
    /// Gets the animator attached to this entity
    /// </summary>
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    /// <summary>
    /// Sets the animator walking directions and speed
    /// </summary>
    private void Update()
    {
        Vector2 face = entityMovement.GetFace();
        //Debug.Log(face.x + " " + face.y);
        animator.SetFloat(WALKING_DIRECTION_X, face.x);
        animator.SetFloat(WALKING_DIRECTION_Y, face.y);
        animator.SetFloat(SPEED, entityMovement.GetMovementNormalized().magnitude);
    }
}

