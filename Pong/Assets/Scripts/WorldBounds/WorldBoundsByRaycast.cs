using UnityEngine;

public class WorldBoundsByRaycast : MonoBehaviour, IWorldBounds
{
    [SerializeField] private float raycastRange;

    private Transform currentTransfrom;
    private Vector3 up;
    private Vector3 forward;

    private void Awake()
    {
        currentTransfrom = this.transform;
    }

    private void Start()
    {
        up = currentTransfrom.TransformDirection(Vector3.forward);
        forward = currentTransfrom.TransformDirection(Vector3.left);
    }

    public bool IsWithinTopBounds()
    {
        if (Physics.Raycast(currentTransfrom.position, up, raycastRange))
        {
            return false;
        }

        return true;
    }

    public bool IsWithinBottomBounds()
    {
        if (Physics.Raycast(currentTransfrom.position, -up, raycastRange))
        {
            return false;
        }

        return true;
    }

    public bool IsWithinForwardBounds()
    {
        if (Physics.Raycast(currentTransfrom.position, forward, raycastRange))
        {
            return false;
        }

        return true;
    }

    public bool IsWithinBackwardBounds()
    {
        if (Physics.Raycast(currentTransfrom.position, -forward, raycastRange))
        {
            return false;
        }

        return true;
    }
}
