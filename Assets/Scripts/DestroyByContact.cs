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
        if (col.gameObject.tag.Equals("SpaceStation"))
        {
            HandleShieldCollision(col.gameObject.tag);
        }
        if (col.gameObject.tag.Equals("SpaceStationCore"))
        {
            HandleCoreCollision();
        }
	}

    void HandleCoreCollision(){
        switch(gameObject.tag) {
            case "Player1":
                gameManager[0].GetComponent<GameManager>().player1Score += 1;
                break;
            case "Player2":
                gameManager[0].GetComponent<GameManager>().player2Score += 1;
                break;
            case "Player3":
                gameManager[0].GetComponent<GameManager>().player3Score += 1;
                break;
            case "Player4":
                gameManager[0].GetComponent<GameManager>().player4Score += 1;
                break;
        }
    }

    void HandleShieldCollision(string tag) {
        HandlePlayerCollide("Player1", "Player1Spawn", Quaternion.Euler(0, 0, 0));
        HandlePlayerCollide("Player2", "Player2Spawn", Quaternion.Euler(0, 90, 0));
        HandlePlayerCollide("Player3", "Player3Spawn", Quaternion.Euler(0, -180, 0));
        HandlePlayerCollide("Player4", "Player4Spawn", Quaternion.Euler(0, -90, 0));
    }

    void HandlePlayerCollide(string tag, string spawnTag, Quaternion rotation) {
        if(gameObject.tag.Equals(tag)){
            GameObject boom = Instantiate(explosion,
                gameObject.transform.position,
                rotation) as GameObject;
            GameObject[] playerSpawnArray = GameObject.FindGameObjectsWithTag(spawnTag);
            GameObject player = Instantiate(missle,
                playerSpawnArray[0].transform.position,
                rotation) as GameObject;
            player.tag = tag;
            Destroy(gameObject);
        }
    }
}
