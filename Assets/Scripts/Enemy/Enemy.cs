using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private EntityMovement entityMovement;
    [SerializeField] private GameObject target;

    // Update is called once per frame
    private void Update()
    {
        Vector2 movementVector = Vector2.zero;
        //movementVector = Vector2.MoveTowards(transform.position, playerTarget.transform.position, 1);
        movementVector = Vector2.MoveTowards(transform.position, target.transform.position, entityMovement.GetMoveSpeed() * Time.deltaTime);
        //Debug.Log(transform.position);
        //Debug.Log(movementVector.x - transform.position.x);
        Debug.Log("movementVector:" + movementVector);
        //transform.position = movementVector;
        entityMovement.MoveTo(movementVector);
    }
}
