using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float yAngle;
    [SerializeField] float xAngle;
    [SerializeField] float zAngle;

    void Start()
    {

    }

    void Update()
    {
        transform.Rotate(xAngle, yAngle, zAngle);
    }
}
