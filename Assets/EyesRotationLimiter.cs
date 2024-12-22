using UnityEngine;

public class EyesRotationLimiter : MonoBehaviour
{
    public float minX = -45f;
    public float maxX = 45f;
    public float minY = -45f;
    public float maxY = 45f;

    void LateUpdate()
    {
        Vector3 rotation = transform.localEulerAngles;

        float normalizedX = NormalizeAngle(rotation.x);
        if (normalizedX < minX)
            normalizedX = minX;
        else if (normalizedX > maxX)
            normalizedX = maxX;

        float normalizedY = NormalizeAngle(rotation.y);
        if (normalizedY < minY)
            normalizedY = minY;
        else if (normalizedY > maxY)
            normalizedY = maxY;

        rotation.x = normalizedX;
        rotation.y = normalizedY;
        transform.localEulerAngles = rotation;
    }

    private float NormalizeAngle(float angle)
    {
        if (angle > 180f)
            angle -= 360f;
        return angle;
    }
}
