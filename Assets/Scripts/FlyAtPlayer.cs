using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    // all game object have transform component
    [SerializeField] Transform player;
    [SerializeField] float projectileSpeed = 10f;
    Vector3 playerPos;

    void Start()
    {
        playerPos = player.transform.position;
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPos, Time.deltaTime * projectileSpeed);
    }
}
