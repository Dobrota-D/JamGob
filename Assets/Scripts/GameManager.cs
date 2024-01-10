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
        Score = 0;
        Multiplier = 1;
        UpdateScoreText();
        UpdateMultiplierText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScoreText()
    {
        _scoreText.text = "Score: " + Score;
    }

    public void UpdateMultiplierText()
    {
        _multiplierText.text = "Multiplier: " + Multiplier;
    }

    public void IncreaseScore(int amount)
    {
        Score += amount * Multiplier;
        UpdateScoreText();
    }

    // reset the scene 
    public void Reset()
    {
        SceneManager.LoadScene("Main");
    }
}
