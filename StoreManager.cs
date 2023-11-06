using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StoreManager : MonoBehaviour
{
        [SerializeField] TextMeshProUGUI shieldCount;
        [SerializeField] TextMeshProUGUI bombCount;
        [SerializeField] TextMeshProUGUI magnetCount;

        private void Update()
        {
                shieldCount.text = PlayerPrefs.GetInt("ShieldCount").ToString();
                bombCount.text = PlayerPrefs.GetInt("BombCount").ToString();
                magnetCount.text = PlayerPrefs.GetInt("MagnetCount").ToString();
        }

        public void OnaddshieldsPurchaseComplete()
        {
                PlayerPrefs.SetInt("ShieldCount", (PlayerPrefs.GetInt("ShieldCount") + 5));
        }

        public void OnaddbombsPurchaseComplete()
        {
                PlayerPrefs.SetInt("BombCount", (PlayerPrefs.GetInt("BombCount") + 5));
        }

        public void OnaddmagnetsPurchaseComplete()
        {
                PlayerPrefs.SetInt("MagnetCount", (PlayerPrefs.GetInt("MagnetCount") + 5));
        }
}
