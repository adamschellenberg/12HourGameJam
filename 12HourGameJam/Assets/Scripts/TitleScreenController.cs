using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleScreenController : MonoBehaviour
{

    [SerializeField] private Button playButton;
    [SerializeField] private Button quitButton;
    [SerializeField] private Button creditsButton;

    // Start is called before the first frame update
    void Start()
    {
        playButton.onClick.AddListener(PlayGame);
        quitButton.onClick.AddListener(QuitGame);
        creditsButton.onClick.AddListener(ShowCredits);
    }

    void PlayGame() {
        SceneManager.LoadScene("main");
    }

    void QuitGame() {
        Application.Quit();
    }

    void ShowCredits() {
        SceneManager.LoadScene("credits");
    }

}
