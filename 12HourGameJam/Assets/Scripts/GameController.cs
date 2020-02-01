using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    [SerializeField] private GameObject menuCanvas;
    private bool isPaused = false;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("return")) {
            // pause
            PauseGame();
        }
    }

    void PauseGame() {
        if(isPaused) {
            // close pause menu
            menuCanvas.SetActive(false);
            Time.timeScale = 1;
            isPaused = false;
        } else {
            // open pause menu
            menuCanvas.SetActive(true);
            Time.timeScale = 0;
            isPaused = true;
        }
    }
}
