using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    private const string IS_WALKING = "IsWalking";
    private Animator myAnimator;
    [SerializeField] private Player player;


    private void Awake()
    {
        myAnimator = GetComponent<Animator>();

    }

    private void Update()
    {
        myAnimator.SetBool(IS_WALKING, player.IsWalking());
    }
}
