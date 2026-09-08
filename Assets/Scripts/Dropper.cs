using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToWait = 2f;
    void Start()
    {

    }
    void Update()
    {
        if (Time.time >= timeToWait)
        {
            GetComponent<Rigidbody>().useGravity = true;
        }
    }
}
