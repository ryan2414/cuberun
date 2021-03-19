using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour {
    public static GameManager instace;
    private void Awake() {
        instace = this;
        Time.timeScale = 1;
    }

    public GameObject gameOverUI;
    public Text p1Win;
    public Text p2Win;

    private void Start() {
        p1Win.enabled = false;
        p2Win.enabled = false;
        gameOverUI.SetActive(false);
    }

    public void GameFinish(GameObject name) {
        gameOverUI.SetActive(true);
        if(name.name == "Player") {
            p2Win.enabled = true;
        }else if(name.name == "Player2") {
            p1Win.enabled = true;
        }
        Time.timeScale = 0;
        

    }
    public void OnRestart() {
        
        SceneManager.LoadScene(0);
    }
}
