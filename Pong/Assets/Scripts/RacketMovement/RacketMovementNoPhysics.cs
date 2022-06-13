using UnityEngine;

public class RacketMovementNoPhysics : MonoBehaviour, IRacketMovement
{
    [SerializeField] private float movementSpeed;

    private Transform currentTransform;
    private IWorldBounds worldBounds;

    private void Awake()
    {
        currentTransform = this.transform;
        worldBounds = transform.GetComponent<IWorldBounds>();
    }

    public void MoveUp()
    {
        if (worldBounds.IsWithinTopBounds())
        {
            Vector3 movementDirection = new Vector3(currentTransform.position.x, 0, 100);
            currentTransform.position = Vector3.MoveTowards(currentTransform.position, movementDirection, movementSpeed);
        }
    }

    public void MoveDown()
    {
        if (worldBounds.IsWithinBottomBounds())
        {
            Vector3 movementDirection = new Vector3(currentTransform.position.x, 0, -100);
            currentTransform.position = Vector3.MoveTowards(currentTransform.position, movementDirection, movementSpeed);
        }
    }
}
