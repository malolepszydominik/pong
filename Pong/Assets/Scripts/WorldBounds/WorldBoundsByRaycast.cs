using UnityEngine;

public class WorldBoundsByRaycast : MonoBehaviour, IWorldBounds
{
    [SerializeField] private float raycastRange;

    private Transform currentTransfrom;
    private Vector3 forward;

    private void Start()
    {
        currentTransfrom = this.transform;
        forward = currentTransfrom.TransformDirection(Vector3.forward);
    }

    public bool IsWithinTopBounds()
    {
        if (Physics.Raycast(currentTransfrom.position, forward, raycastRange))
        {
            return false;
        }

        return true;
    }

    public bool IsWithinBottomBounds()
    {
        if (Physics.Raycast(currentTransfrom.position, -forward, raycastRange))
        {
            return false;
        }

        return true;
    }
}
