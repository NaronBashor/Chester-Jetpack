using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MovingBackground : MonoBehaviour
{
        [SerializeField] private GameObject background;
        [SerializeField] private float moveSpeed;

        private void Update()
        {
                if (background.transform.position.x > -75 && GameObject.Find("Player").GetComponent<Animator>().GetBool("isAlive"))
                {
                        background.transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
                }
        }
}
