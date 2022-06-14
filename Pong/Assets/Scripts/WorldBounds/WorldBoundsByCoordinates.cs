using UnityEngine;

public class WorldBoundsByCoordinates : MonoBehaviour, IWorldBounds
{
    [SerializeField] private float maxZPosition;
    [SerializeField] private float maxXPosition;
    [SerializeField] private float minXPosition;

    private Transform currentTransform;
    void Awake()
    {
        currentTransform = transform; 
    }

    public bool IsWithinTopBounds()
    {
        if (currentTransform.position.z < maxZPosition)
            return true;

        return false;
    }

    public bool IsWithinBottomBounds()
    {
        if (currentTransform.position.z > -maxZPosition)
            return true;

        return false;
    }

    public bool IsWithinForwardBounds()
    {
        if (currentTransform.position.x > minXPosition)
            return true;

        return false;
    }

    public bool IsWithinBackwardBounds()
    {
        if (currentTransform.position.x < maxXPosition)
            return true;

        return false;
    }
}
