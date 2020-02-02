using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VillagerController : MonoBehaviour

{
    [SerializeField] private GameObject speechCanvas;
    [SerializeField] private Text speechText;
    public bool speakingToPlayer;

    [SerializeField] private bool Pokey;

    // Start is called before the first frame update
    void Start()
    {
        speakingToPlayer = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (speakingToPlayer) {
            SpeakToPlayer();
        }
    }

    void SpeakToPlayer() {
        speechCanvas.SetActive(true);
    }


}
