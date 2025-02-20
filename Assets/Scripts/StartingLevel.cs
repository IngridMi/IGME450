using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class StartingLevel : MonoBehaviour
{
    public Button button1;

    [SerializeField] private GameObject ball;

    private void Awake()
    {
        GameManager.OnGameStateChanged += GameManager_OnGameStateChanged;
    }

    void OnDestroy()
    {
        GameManager.OnGameStateChanged -= GameManager_OnGameStateChanged;
    }

    private void GameManager_OnGameStateChanged(GameManager.GameState obj)
    {
        if(obj == GameManager.GameState.Live)
        {
            ball.SetActive(true);
            ball.GetComponent<Ball>().ResetPosition();
            gameObject.SetActive(false);
        }
        else if (obj == GameManager.GameState.Building)
        {
            gameObject.SetActive(true);
        }
    }

    //private void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.P))
    //    {
    //        OnClick();
    //        print("test");
    //    }
    //}

    public void OnClick()
    {
        ball.SetActive(true);
        ball.GetComponent<Ball>().ResetPosition();
        gameObject.SetActive(false);
    }
}
