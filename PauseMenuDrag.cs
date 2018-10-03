using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PauseMenuDrag : MonoBehaviour {

    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public static bool isCorrect = false;
    public Transform cu1;
    public Transform alu;
    public Transform cache;
    public Transform cu2;
    public Text submitButtonText;
    public GameObject success;
    public GameObject fail;
    public int numOfTryes = 3;
    public GameObject point3;
    public GameObject point2;
    public GameObject point1;
    public Text playerSentence;




    public void OnClick()
    {
        if (GameIsPaused)
        {
            Resume();

        }
        else
        {
            Pause();
        }
    }

    void Resume()
    {
        if(isCorrect == true)
        {
            Application.LoadLevel("OperationsScene");
            isCorrect = false;
        }
        else if(numOfTryes == 0)
        {
            Application.LoadLevel("ComponentsScene");

        }
        else
        {
            pauseMenuUI.SetActive(false);
            Time.timeScale = 1f;
            submitButtonText.text = "Submit";
            GameIsPaused = false;
        }
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        IsCorrect();
    }

    void IsCorrect()
    {
        if(cu1.parent.name == "SlotCU" && alu.parent.name == "SlotALU" && cache.parent.name == "SlotCACHE" && cu2.parent.name == "SlotCU")
        {
            isCorrect = true;
        }
        else
        {
            isCorrect = false;
        }
        Changes();
    }

    void Changes()
    {
        if (isCorrect == true)
        {
            submitButtonText.text = "Continue Lesson";
            fail.SetActive(false);
            success.SetActive(true);
            playerSentence.text = "Your score is " + numOfTryes;
        }
        else
        {
            submitButtonText.text = "Try Again";
            success.SetActive(false);
            fail.SetActive(true);
            Tryes();
        }
    }

    void Tryes()
    {
        if(numOfTryes == 3)
        {
            point3.SetActive(false);
        }
        if (numOfTryes == 2)
        {
            point2.SetActive(false);
        }
        if (numOfTryes == 1)
        {
            playerSentence.text = "Read components carefully then try again";
            submitButtonText.text = "Components";
            point1.SetActive(false);
        }
        numOfTryes = numOfTryes - 1;
    }
}
