using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField]
    private TMP_Text _scoreText;

    [SerializeField]
    private TMP_Text _multiplierText;

    public int Score;

    public int Multiplier;

    // Awake the instance of the GameManager
    void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        Score = -200;
        Multiplier = 1;
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateMultiplierText();
        UpdateScoreText();
        
        
    }

    public void UpdateScoreText()
    {
        _scoreText.text = Score + " Score";
    }

    public void UpdateMultiplierText()
    {
        _multiplierText.text =  Multiplier + "X";
    }

    public void IncreaseScore(int amount)
    {
        Score += amount * Multiplier;
        UpdateScoreText();
    }

  

    
}
