using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDetector : MonoBehaviour
{
        private void OnTriggerEnter2D(Collider2D collision)
        {
                if (collision != null)
                {
                        if (collision.CompareTag("Enemy"))
                        {
                                collision.GetComponent<Animator>().SetTrigger("death");
                                collision.GetComponent<Animator>().SetBool("isAlive", false);
                                StartCoroutine(Delay());
                                IEnumerator Delay()
                                {
                                        yield return new WaitForSeconds(.25f);                                        
                                        Destroy(collision.gameObject);
                                }
                        }
                }
        }
}
