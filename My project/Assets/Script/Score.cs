using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int score;
    public static int scoreMax = 15;
    [SerializeField] private GameObject scoreText;

    void Update()
    {
        scoreText.GetComponent<Text>().text = score.ToString() + " / " + scoreMax.ToString();
    }
}
