using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class EnemyDamageOnTouch : MonoBehaviour
{
    public int damage = 10;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerHealthManager playerHealth = collision.gameObject.GetComponent<PlayerHealthManager>();
            if (playerHealth != null)
            {
                playerHealth.RecibirPupa(damage);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerHealthManager playerHealth = other.GetComponent<PlayerHealthManager>();
            if (playerHealth != null)
            {
                playerHealth.RecibirPupa(damage);
            }
        }
    }
}
