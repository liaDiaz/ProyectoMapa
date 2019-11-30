using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public enum GameState
    {
        PLAY, PACMAN_DYING, PACMAN_DEAD, GAME_OVER, GAME_WON
    };
    public GameState gameState = GameState.PLAY;
    [Range(1,10)]
    public float cardVulnerableDuration = 7.0f;//how long the cards should be vulnerable for
    [Range(1,5)]
    public float cardVulnerableEndWarningDuration = 2.0f;
    
    public Image gameWonScreen;
    public Image gameOverScreen;
    public Button siguiente;

    public GameObject alice;
    public AnimationClip pacmanDeathAnimation;
    public List<GameObject> cards;
    public List<GameObject> pills;

    public AudioSource pacmanKilledSound;
    public AudioSource gameWonSound;
    public AudioSource gameOverSound;

    private static GameManager instance;
    private float respawnTime;
    private float invulnerableTime = 0;//when the cards will become invulnerable again

	// Use this for initialization
	void Start () {
		if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        gameOverScreen.enabled = false;
        gameWonScreen.enabled = false;
        siguiente.gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		switch (gameState)
        {
            case GameState.PLAY:
                bool foundPill = false;
                foreach (GameObject pill in pills)
                {
                    if (pill.activeSelf)
                    {
                        foundPill = true;
                        break;
                    }
                }
                if (!foundPill)
                {
                    gameState = GameState.GAME_WON;
                }
                break;
            case GameState.PACMAN_DYING:
                if (Time.time > respawnTime)
                {
                    gameState = GameState.PACMAN_DEAD;
                    respawnTime = Time.time + 1;
                    alice.SetActive(false);
                }
                break;
            case GameState.PACMAN_DEAD:
                if (Time.time > respawnTime)
                {
                    gameState = GameState.PLAY;
                    alice.SetActive(true);
                    PlayerController playerController = alice.GetComponent<PlayerController>();
                    playerController.setLivesLeft(playerController.livesLeft - 1);
                    if (playerController.livesLeft >= 0)
                    {
                        playerController.setAlive(true);
                    }
                    else
                    {
                        gameState = GameState.GAME_OVER;
                    }
                    alice.transform.position = Vector2.zero;
                    foreach (GameObject card in cards)
                    {
                        card.GetComponent<CardController>().reset();
                    }
                }
                break;
            case GameState.GAME_OVER:
                gameOverScreen.enabled = true;
                gameWonScreen.enabled = false;
                
                if (!gameOverSound.isPlaying)
                {
                    gameOverSound.Play();
                }
    
                if (Input.anyKeyDown)
                {
                    gameState = GameState.PLAY;
                    gameOverScreen.enabled = false;
                    gameWonScreen.enabled = false;
                }
                break;
            case GameState.GAME_WON:
                gameOverScreen.enabled = false;
                gameWonScreen.enabled = true;
                siguiente.gameObject.SetActive(true);

                if (!gameWonSound.isPlaying)
                {
                    gameWonSound.Play();
                }
                if (Input.anyKeyDown)
                {
                    gameState = GameState.PLAY;
                    gameOverScreen.enabled = false;
                    gameWonScreen.enabled = false;
                }
                break;
        }
        //Card Vulnerability
        if (invulnerableTime > 0)
        {
            if (Time.time > invulnerableTime)
            {
                invulnerableTime = 0;
                foreach (GameObject card in cards)
                {
                    card.GetComponent<CardController>().setVulnerable(false);
                }
            }
            else if (Time.time > invulnerableTime - cardVulnerableEndWarningDuration
                && (Time.time *10)%2 < 0.1f)
            {
                foreach (GameObject card in cards)
                {
                    card.GetComponent<CardController>().blink();
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
	}

    public static void pacmanKilled()
    {
        instance.alice.GetComponent<PlayerController>().setAlive(false);
        instance.gameState = GameState.PACMAN_DYING;
        instance.respawnTime = Time.time + instance.pacmanDeathAnimation.length;
        instance.pacmanKilledSound.Play();
        foreach (GameObject card in instance.cards)
        {
            card.GetComponent<CardController>().freeze(true);
        }
    }

    public void resetGame()
    {
        alice.transform.position = Vector2.zero;
        PlayerController playerController = alice.GetComponent<PlayerController>();
        playerController.setLivesLeft(2);
        playerController.setAlive(true);
        siguiente.gameObject.SetActive(false);
        gameOverScreen.enabled = false;
        foreach (GameObject card in cards)
        {
            card.GetComponent<CardController>().reset();
        }
        foreach (GameObject pill in pills)
        {
            pill.SetActive(true);
        }
    }

    public static void makeCardsVulnerable()
    {
        instance.invulnerableTime = Time.time + instance.cardVulnerableDuration;
        foreach (GameObject card in instance.cards)
        {
            card.GetComponent<CardController>().setVulnerable(true);
        }
    }

    
}
