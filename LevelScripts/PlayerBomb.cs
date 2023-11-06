using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBomb : MonoBehaviour
{
        Animator anim;

        [SerializeField] private float bombDelay = 2f;
        [SerializeField] private AudioSource bombExplode;

        private void Start()
        {
                anim = GetComponent<Animator>();

                StartCoroutine(Delay());
        }

        private IEnumerator Delay()
        {
                yield return new WaitForSeconds(bombDelay);
                anim.SetTrigger("explode");
                bombExplode.Play();
                yield return new WaitForSeconds(.4f);
                Destroy(gameObject);
        }
}
