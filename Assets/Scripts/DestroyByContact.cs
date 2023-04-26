using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour
{
    public GameObject missle;
    public GameObject explosion;
    GameObject[] gameManager;

    Quaternion rotation = Quaternion.identity;

    void Start()
    {
        gameManager = GameObject.FindGameObjectsWithTag("GameManager");
    }

    void OnCollisionEnter(Collision col)
	{
        //Debug.Log("Collision");
        if (col.gameObject.tag.Equals("SpaceStation")
            || col.gameObject.tag.Equals("SpaceStationCore"))
        {
            HandleCollision(col.gameObject.tag);
        }
	}

    void HandleCollision(string tag) {
        if(gameObject.tag.Equals("Player1")){
            GameObject explosion1 = Instantiate(explosion,
                gameObject.transform.position,
                rotation) as GameObject;
            Destroy(gameObject);
            GameObject[] player1SpawnArray = GameObject.FindGameObjectsWithTag("Player1Spawn");
            GameObject player1 = Instantiate(missle,
                player1SpawnArray[0].transform.position,
                rotation) as GameObject;
            player1.tag = "Player1";
            if(tag.Equals("SpaceStationCore")){
                gameManager[0].GetComponent<GameManager>().player1Score += 1;
            }
        }
        if(gameObject.tag.Equals("Player2")){
            GameObject explosion2 = Instantiate(explosion,
                gameObject.transform.position,
                rotation) as GameObject;
            Destroy(gameObject);
            rotation = Quaternion.Euler(0, 90, 0);
            GameObject[] player2SpawnArray = GameObject.FindGameObjectsWithTag("Player2Spawn");
            GameObject player2 = Instantiate(missle,
                player2SpawnArray[0].transform.position,
                rotation) as GameObject;
            player2.tag = "Player2";
            if(tag.Equals("SpaceStationCore")){
                gameManager[0].GetComponent<GameManager>().player2Score += 1;
            }
        }
        if(gameObject.tag.Equals("Player3")){
            GameObject explosion3 = Instantiate(explosion,
                gameObject.transform.position,
                rotation) as GameObject;
            Destroy(gameObject);
            rotation = Quaternion.Euler(0, -180, 0);
            GameObject[] player3SpawnArray = GameObject.FindGameObjectsWithTag("Player3Spawn");
            GameObject player3 = Instantiate(missle,
                player3SpawnArray[0].transform.position,
                rotation) as GameObject;
            player3.tag = "Player3";
            if(tag.Equals("SpaceStationCore")){
                gameManager[0].GetComponent<GameManager>().player3Score += 1;
            }
        }
        if(gameObject.tag.Equals("Player4")){
            GameObject explosion4 = Instantiate(explosion,
                gameObject.transform.position,
                rotation) as GameObject;
            Destroy(gameObject);
            rotation = Quaternion.Euler(0, -90, 0);
            GameObject[] player4SpawnArray = GameObject.FindGameObjectsWithTag("Player4Spawn");
            GameObject player4 = Instantiate(missle,
                player4SpawnArray[0].transform.position,
                rotation) as GameObject;
            player4.tag = "Player4";
            if(tag.Equals("SpaceStationCore")){
                gameManager[0].GetComponent<GameManager>().player4Score += 1;
            }
        }
    }
}
