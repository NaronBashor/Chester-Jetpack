using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
        Rigidbody2D rb;
        Animator anim;

        #region Inspector

        [Header("Locations")]
        [SerializeField] Transform bombLocation;

        [Header("GameObjects")]
        [SerializeField] private GameObject smokeAnimation;
        [SerializeField] private GameObject bombPrefab;
        [SerializeField] private GameObject magnetAnimation;
        [SerializeField] private GameObject pausePanel;

        [Header("Variables")]
        [SerializeField] private float jumpForce;
        [SerializeField] private int coinTotal;
        [SerializeField] private float scoreCounter;
        [SerializeField] private int bombCount;
        [SerializeField] private int magnetCount;
        [SerializeField] private int shieldCount;
        [SerializeField] private int magnetTimer;

        [Header("TMP Objects")]
        [SerializeField] private TextMeshProUGUI coinCounterText;
        [SerializeField] private TextMeshProUGUI scoreText;
        [SerializeField] private TextMeshProUGUI deathScoreText;
        [SerializeField] private TextMeshProUGUI deathShieldText;
        [SerializeField] private TextMeshProUGUI deathBombText;
        [SerializeField] private TextMeshProUGUI deathMagnetText;
        [SerializeField] private TextMeshProUGUI bombCounterText;
        [SerializeField] private TextMeshProUGUI magnetCounterText;
        [SerializeField] private TextMeshProUGUI shieldCounterText;

        [Header("Sounds")]
        [SerializeField] private AudioSource itemPickup;
        [SerializeField] private AudioSource coinCollect;
        [SerializeField] private AudioSource playerDeath;
        [SerializeField] private AudioSource playerJetpack;
        [SerializeField] private AudioSource shieldActivate;
        [SerializeField] private AudioSource magnetActivate;

        #endregion

        private bool gamePaused = false;
        private bool prefsUpdated = false;
        private bool deathSoundPlayed = false;

        public float ScoreCounter
        {
                get
                {
                        return scoreCounter;
                }
                set
                {
                        scoreCounter = value;
                }
        }

        public int CoinTotal
        {
                get
                {
                        return coinTotal;
                }
                set
                {
                        coinTotal = value;
                }
        }

        public int BombCount
        {
                get
                {
                        return bombCount;
                }
                set
                {
                        bombCount = value;
                }
        }

        public int MagnetCount
        {
                get
                {
                        return magnetCount;
                }
                set
                {
                        magnetCount = value;
                }
        }

        public int ShieldCount
        {
                get
                {
                        return shieldCount;
                }
                set
                {
                        shieldCount = value;
                }
        }

        public bool CanMove
        {
                get
                {
                        return anim.GetBool("canMove");
                }
        }

        private void Awake()
        {
                rb = GetComponent<Rigidbody2D>();
                anim = rb.GetComponent<Animator>();

                anim.SetInteger("characterChoice", PlayerPrefs.GetInt("CharacterInt"));
                anim.SetBool("levelEnd", false);

                prefsUpdated = false;
                deathSoundPlayed = false;

                scoreCounter = 0;
                coinTotal = 0;
        }

        private void Start()
        {
                smokeAnimation.SetActive(false);
                magnetAnimation.SetActive(false);

                bombCount = PlayerPrefs.GetInt("BombCount");
                shieldCount = PlayerPrefs.GetInt("ShieldCount");
                magnetCount = PlayerPrefs.GetInt("MagnetCount");
        }

        private void Update()
        {
                if (Input.touchCount > 0)
                {
                        if (!EventSystem.current.IsPointerOverGameObject())
                        {
                                playerJetpack.Play();
                                smokeAnimation.SetActive(true);
                                rb.velocity = Vector2.up * jumpForce;
                        }
                }

                if (Input.GetKeyUp(KeyCode.Space) || !anim.GetBool("isAlive"))
                {
                        smokeAnimation.SetActive(false);
                }
                if (anim.GetBool("isAlive") && !anim.GetBool("levelEnd"))
                {
                        scoreCounter += Time.deltaTime * 100;
                }
                if (transform.position.x < -11)
                {
                        Damageable dam = GetComponent<Damageable>();
                        dam.OnHit(dam.Health);
                }
                if (anim.GetBool("magnetActive"))
                {
                        magnetAnimation.SetActive(true);
                }
                else if (!anim.GetBool("magnetActive"))
                {
                        magnetAnimation.SetActive(false);
                }

                if (anim.GetBool("levelEnd") && !prefsUpdated)
                {
                        PlayerPrefs.SetInt("ShieldCount", shieldCount);
                        PlayerPrefs.SetInt("BombCount", bombCount);
                        PlayerPrefs.SetInt("MagnetCount", magnetCount);

                        prefsUpdated = true;
                }

                if (!anim.GetBool("isAlive") && !deathSoundPlayed)
                {
                        playerDeath.Play();
                        deathSoundPlayed = true;
                }

                bombCounterText.text = bombCount.ToString();
                magnetCounterText.text = magnetCount.ToString();
                shieldCounterText.text = shieldCount.ToString();
                scoreText.text = scoreCounter.ToString("#,#");
                deathScoreText.text = scoreCounter.ToString("#,#");
                deathShieldText.text = shieldCount.ToString();
                deathBombText.text = bombCount.ToString();
                deathMagnetText.text = magnetCount.ToString();
                coinCounterText.text = coinTotal.ToString();
        }

        public void DropBomb()
        {
                if (bombCount > 0 && anim.GetBool("isAlive") && !anim.GetBool("levelEnd"))
                {
                        Quaternion rotation = Quaternion.identity;
                        rotation.eulerAngles = new Vector3(0, 0, 90);
                        GameObject bombInstance = Instantiate(bombPrefab, bombLocation.position, rotation);
                        bombInstance.transform.parent = GameObject.Find("Background").transform;
                        bombCount--;
                }
        }

        public void UseMagnet()
        {
                if (magnetCount > 0 && anim.GetBool("isAlive") && !anim.GetBool("levelEnd") && !anim.GetBool("magnetActive"))
                {
                        magnetActivate.Play();
                        anim.SetBool("magnetActive", true);
                        magnetCount--;
                        StartCoroutine(Delay());
                        IEnumerator Delay()
                        {
                                yield return new WaitForSeconds(magnetTimer);
                                anim.SetBool("magnetActive", false);
                        }
                }
        }

        public void UseShield()
        {
                if (shieldCount > 0 && anim.GetBool("isAlive") && !anim.GetBool("levelEnd") && !anim.GetBool("shieldActive"))
                {
                        shieldActivate.Play();
                        anim.SetBool("shieldActive", true);
                        shieldCount--;
                }
        }

        public void PauseGame()
        {
                gamePaused = !gamePaused;
                if (gamePaused)
                {
                        Time.timeScale = 0;
                        pausePanel.SetActive(true);
                }
                else if (!gamePaused)
                {
                        Time.timeScale = 1;
                        pausePanel.SetActive(false);
                }
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
                if (collision != null)
                {
                        if (collision.CompareTag("Coin"))
                        {
                                coinCollect.Play();
                        }
                        if (collision.CompareTag("Pickup"))
                        {
                                itemPickup.Play();
                        }
                }
        }
}
