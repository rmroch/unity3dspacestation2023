using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject misslePlayer1;
    public GameObject misslePlayer2;
    public GameObject misslePlayer3;
    public GameObject misslePlayer4;
    public GameObject player1Spawn;
    public GameObject player2Spawn;
    public GameObject player3Spawn;
    public GameObject player4Spawn;
    public TMP_Text player1ScoreText;
    public TMP_Text player2ScoreText;
    public TMP_Text player3ScoreText;
    public TMP_Text player4ScoreText;
    public int player1Score;
    public int player2Score;
    public int player3Score;
    public int player4Score;

    Quaternion rotation = Quaternion.identity;

    // Start is called before the first frame update
    void Start()
    {
        GameObject[] player1 = GameObject.FindGameObjectsWithTag("Player1");
        if(player1.Length == 0) {
            GameObject newPlayer1 = Instantiate(misslePlayer1,
                player1Spawn.transform.position,
                rotation) as GameObject;
        }
        GameObject[] player2 = GameObject.FindGameObjectsWithTag("Player2");
        if(player2.Length == 0) {
            rotation = Quaternion.Euler(0, 90, 0);
            GameObject newPlayer2 = Instantiate(misslePlayer2,
                player2Spawn.transform.position,
                rotation) as GameObject;
        }
        GameObject[] player3 = GameObject.FindGameObjectsWithTag("Player3");
        if(player3.Length == 0) {
            rotation = Quaternion.Euler(0, -180, 0);
            GameObject newPlayer3 = Instantiate(misslePlayer3,
                player3Spawn.transform.position,
                rotation) as GameObject;
        }
        GameObject[] player4 = GameObject.FindGameObjectsWithTag("Player4");
        if(player4.Length == 0) {
            rotation = Quaternion.Euler(0, -90, 0);
            GameObject newPlayer4 = Instantiate(misslePlayer4,
                player4Spawn.transform.position,
                rotation) as GameObject;
        }
    }

    // Update is called once per frame
    void Update()
    {
        player1ScoreText.text = player1Score.ToString();
        player2ScoreText.text = player2Score.ToString();
        player3ScoreText.text = player3Score.ToString();
        player4ScoreText.text = player4Score.ToString();
    }
}
