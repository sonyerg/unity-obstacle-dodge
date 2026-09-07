using UnityEngine;

public class Dropper : MonoBehaviour
{
    void Start()
    {
        
    }
    void Update()
    {
        if (Mathf.Approximately(Time.time, Mathf.Round(Time.time)))
        {
            Debug.Log("Time elapsed: " + Time.time);
        }
    }
}
