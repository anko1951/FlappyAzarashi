using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearTrigger : MonoBehaviour
{
    GameController gameController;
    // Start is called before the first frame update
    void Start()
    {
       gameController = GameObject.FindObjectOfType<GameController>(); 
    }

    void OnTriggerExit2D(Collider2D other) {
        gameController.IncreaseScore();
    }
}
