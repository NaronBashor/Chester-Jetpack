using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeTrap : MonoBehaviour
{
        [SerializeField] private float spikeDamage;

        private void OnTriggerEnter2D(Collider2D collision)
        {
                if (collision.CompareTag("Player"))
                {
                        Damageable dam = collision.GetComponent<Damageable>();
                        if (dam != null)
                        {
                                dam.OnHit(spikeDamage);
                        }
                }
        }
}
