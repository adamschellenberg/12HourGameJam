using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CreditsController : MonoBehaviour
{

    [SerializeField] private Button backButton;
    // Start is called before the first frame update
    void Start()
    {
        backButton.onClick.AddListener(ReturnToMenu);
    }

    void ReturnToMenu() {
        SceneManager.LoadScene("titlescreen");
    }

}
