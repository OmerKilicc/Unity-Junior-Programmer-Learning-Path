using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficulityButton : MonoBehaviour
{
    private Button _button;
    public int difficulty;

    private GameManager _gameManager;
    // Start is called before the first frame update
    void Start()
    {
        _button = GetComponent<Button>();
        _button.onClick.AddListener(SetDifficulty);
        _gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        
    }

    void SetDifficulty()
    {
        Debug.Log(gameObject.name + " was clicked");
        _gameManager.StartGame(difficulty);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
