using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacebookLoginPanel : MonoBehaviour
{
        [SerializeField] private GameObject fbPanel;

        private void Awake()
        {
                fbPanel.SetActive(false);
        }

        public void CloseWindow()
        {
                fbPanel.SetActive(false);
        }
}
