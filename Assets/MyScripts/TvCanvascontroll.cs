using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TvCanvascontroll : MonoBehaviour
{
    public TextMeshProUGUI scoreDisplay;
    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        UpdateDisplay();
    }

  public void UpdateDisplay()
    {
        scoreDisplay.text = $"Score: {score}";
    }
    public void AddToscore()
    {
        score++;
        UpdateDisplay();
    }
}
