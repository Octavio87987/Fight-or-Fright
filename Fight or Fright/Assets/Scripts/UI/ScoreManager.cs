using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] TMP_Text Score;
    [SerializeField] TMP_Text HighScore;
    [SerializeField] TMP_Text Money;
    [SerializeField] TMP_Text Alive;
    [SerializeField] TMP_Text Balls;

    int score;
    int money;
    int alive;
    int balls;
    int HighRecord;
    private void Start()
    {
        Enemy.killEnemy = 0;
    }
    void Update()
    {
        if (score >= HighRecord) HighRecord = score;
        HighScore.text = "Record : " + HighRecord.ToString();
        PlayerPrefs.GetInt("My");
        PlayerPrefs.SetInt("My", HighRecord);
        PlayerPrefs.Save();
        money = HealthController.moneyPerKill;
        Money.text = "Money : " + money.ToString();

        score = (int)Enemy.killEnemy;
        Score.text = "Score : " + score.ToString();

        alive = (int)Enemy.aliveEnemies;
        Alive.text = "Alive : " + alive.ToString() + "/10";

        balls = (int)Cannon.currentProjectiles;
        Balls.text = "Balls : " + balls.ToString();

    }
}
