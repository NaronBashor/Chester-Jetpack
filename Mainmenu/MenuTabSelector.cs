using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuTabSelector : MonoBehaviour
{
        [SerializeField] private GameObject skinTab;
        [SerializeField] private GameObject itemTab;

        private void Awake()
        {
                skinTab.SetActive(false);
                itemTab.SetActive(true);
        }

        public void SkinTabActive()
        {
                skinTab.SetActive(true);
                itemTab.SetActive(false);
        }

        public void ItemTabActive()
        {
                skinTab.SetActive(false);
                itemTab.SetActive(true);
        }
}
