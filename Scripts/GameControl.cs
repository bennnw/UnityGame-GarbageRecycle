using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    public int gameState = 0, score = 0;
    public Text gameScore;
    public GameObject trashElement1, trashElement2, trashElement3, trashElement4, trashElement5,
        trashElement6, trashElement7, trashElement8, trashElement9, trashElement10, spawnPos, scoreBkg;
    public GameObject[] elementLst = new GameObject[10];
    public Button startGame, restart, help, goBack;
    public Image intro, outro, helpPage;

    private bool isCalled = false;

    void Awake()
    {
        for (int i = 0; i < 10; i++)
        {
            elementLst[i].SetActive(false);
        }
        helpPage.gameObject.SetActive(false);
        outro.gameObject.SetActive(false);
        intro.gameObject.SetActive(true);
        scoreBkg.SetActive(false);

    }

    void Update()
    {
        if (gameState == 0)
        {
            help.onClick.AddListener(this.ViewInstr);
            startGame.onClick.AddListener(this.EnterGame);
        }
        else if (gameState == -1)
        {
            goBack.onClick.AddListener(this.BackToIntro);
        }
        else if (gameState == 1)
        {
            if (!isCalled)
            {
                isCalled = true;
                float spawnX = spawnPos.transform.position.x;
                float spawnY = spawnPos.transform.position.y;
                float spawnZ = spawnPos.transform.position.z;

                for (int i = 0; i < 10; i++)
                {
                    Vector3 spawnPosLoc = new Vector3(Random.Range(spawnX, spawnX + .6f), spawnY, Random.Range(spawnZ, spawnZ - .25f));
                    Instantiate(elementLst[i], spawnPosLoc, Quaternion.identity);
                }
            }
            scoreBkg.SetActive(true);
            gameScore.text = "Item Sorted: " + score.ToString();
            if (score > 5)
            {
                this.GameEnd();
            }
        }
        else
        {
            restart.onClick.AddListener(this.RestartGame);
        }
    }

    void EnterGame()
    {
        intro.gameObject.SetActive(false);
        for (int i = 0; i < 10; i++)
        {
            elementLst[i].SetActive(true);
        }
        gameState = 1;
    }

    void GameEnd()
    {
        outro.gameObject.SetActive(true);
        gameScore.gameObject.SetActive(false);
        scoreBkg.SetActive(false);
        score = 0;

        gameState = 2;
    }

    void ViewInstr()
    {
        helpPage.gameObject.SetActive(true);
        intro.gameObject.SetActive(false);
        gameState = -1;
    }

    void BackToIntro()
    {
        helpPage.gameObject.SetActive(false);
        intro.gameObject.SetActive(true);
        gameState = 0;
    }

    void RestartGame()
    {
        outro.gameObject.SetActive(false);
        intro.gameObject.SetActive(true);
        SceneManager.LoadScene("Sort");
    }
}
