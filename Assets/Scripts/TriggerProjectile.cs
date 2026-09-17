using UnityEngine;

public class TriggerProjectile : MonoBehaviour
{
    [SerializeField] GameObject[] projectiles;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            foreach (GameObject projectile in projectiles)
            {
                projectile.SetActive(true);
                // remove trigger volume when triggeredf
                Destroy(gameObject);
            }
        }
    }
}
