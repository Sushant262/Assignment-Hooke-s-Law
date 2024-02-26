using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI scoreText2;
    float elapsedScore;

   public void Update()
    {
        elapsedScore += Time.deltaTime;
        int minutes = Mathf.FloorToInt(elapsedScore / 60);
        int seconds = Mathf.FloorToInt(elapsedScore % 60);
        scoreText.text = string.Format("Score- {1:00}", minutes, seconds);
        scoreText2.text = string.Format("Score- {1:00}", minutes, seconds);



    }
}
