using UnityEngine;

public class WorldBoundsByCoordinates : MonoBehaviour, IWorldBounds
{
    [SerializeField] private float maxZPosition;
    [SerializeField] private float maxXPosition;

    private Transform currentTransform;
    private Vector3 worldBounds;
    void Awake()
    {
        currentTransform = transform; 
    }

    private void Start()
    {
        worldBounds = new Vector3(maxXPosition, 0, maxZPosition);
    }

    public bool IsWithinTopBounds()
    {
        if (currentTransform.position.z < worldBounds.z)
            return true;

        return false;
    }

    public bool IsWithinBottomBounds()
    {
        if (currentTransform.position.z > -worldBounds.z)
            return true;

        return false;
    }
}
