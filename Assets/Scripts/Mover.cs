using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField]float moveSpeed = 10f;

    void Start()
    {
        
    }

    void Update()
    {
        // Using Time.deltaTime Unity can tell us how long each frame took to execute.
        // Multiplying to Time.deltaTime makes the game "frame rate independent".
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float yValue = 0.0f;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(xValue, yValue, zValue);
    }
}
