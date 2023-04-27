using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissleControl : MonoBehaviour
{
    Ray ray;
    RaycastHit hit;

    public float m_Thrust = 80f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
         ray = Camera.main.ScreenPointToRay(Input.mousePosition);
         if(Physics.Raycast(ray, out hit))
         {
             if(Input.GetMouseButtonDown(0)) {
                switch(hit.collider.gameObject.tag) {
                    case "Player1":
                        //Debug.Log("Player 1 has been clicked");
                        GameObject[] player1GameObject = GameObject.FindGameObjectsWithTag("Player1");
                        if(player1GameObject.Length > 0) {
                            player1GameObject[0].transform.GetChild(0).gameObject.GetComponent<Renderer>().enabled = false;
                            player1GameObject[0].GetComponent<Rigidbody>().AddForce(0f, 0f, m_Thrust, ForceMode.Acceleration);
                        }
                        break;
                    case "Player2":
                        //Debug.Log("Player 2 has been clicked");
                        GameObject[] player2GameObject = GameObject.FindGameObjectsWithTag("Player2");
                        if(player2GameObject.Length > 0) {
                            player2GameObject[0].GetComponent<Rigidbody>().AddForce(m_Thrust, 0f, 0f, ForceMode.Acceleration);
                        }
                        break;
                    case "Player3":
                        //Debug.Log("Player 3 has been clicked");
                        GameObject[] player3GameObject = GameObject.FindGameObjectsWithTag("Player3");
                        if(player3GameObject.Length > 0) {
                            player3GameObject[0].GetComponent<Rigidbody>().AddForce(0f, 0f, -m_Thrust, ForceMode.Acceleration);
                        }
                        break;
                    case "Player4":
                        //Debug.Log("Player 4 has been clicked");
                        GameObject[] player4GameObject = GameObject.FindGameObjectsWithTag("Player4");
                        if(player4GameObject.Length > 0) {
                            player4GameObject[0].GetComponent<Rigidbody>().AddForce(-m_Thrust, 0f, 0f, ForceMode.Acceleration);
                        }
                        break;
                }
            }
         }
    }
}
