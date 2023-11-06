using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MainMenuManager : MonoBehaviour
{
        [SerializeField] private TextMeshProUGUI coinTotalText;

        private void Update()
        {
                coinTotalText.text = PlayerPrefs.GetInt("CoinTotal").ToString();
        }

        public void ExitApplication()
        {
                Application.Quit();
        }
}
