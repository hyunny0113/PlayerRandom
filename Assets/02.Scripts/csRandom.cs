using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csRandom : MonoBehaviour {

    GameObject player;
    GameObject player1;
    GameObject player2;
    GameObject player3;

    public Vector3[] SpawnPos;
    public int SpawnTotal = 5;

    // Use this for initialization
    void Start () {

        SpawnPos = new Vector3[SpawnTotal];

        SpawnPos[0] = new Vector3(-6, 0.5f, 6);
        SpawnPos[1] = new Vector3(6, 0.5f, -6);
        SpawnPos[2] = new Vector3(6, 0.5f, 6);
        SpawnPos[3] = new Vector3(0, 0.5f, 0);
        SpawnPos[4] = new Vector3(-6, 0.5f, -6);
        
        int p1 = Random.Range(0, 5);
        int p2 = Random.Range(0, 5);
        int p3 = Random.Range(0, 5);

        for (int i = 0; i< SpawnTotal; i++) {
            if (p1 == p2)
                p2 = Random.Range(0, 5);
            else if (p2 == p3)
                p3 = Random.Range(0, 5);
            else if (p3 == p1)
                p3 = Random.Range(0, 5);
            else break;
        }
        
        player = GameObject.Find("Player");

        player.transform.FindChild("Player1").gameObject.SetActive(true);
        player.transform.FindChild("Player2").gameObject.SetActive(true);
        player.transform.FindChild("Player3").gameObject.SetActive(true);

        player1 = GameObject.Find("Player1");
        player2 = GameObject.Find("Player2");
        player3 = GameObject.Find("Player3");

        player1.transform.position = SpawnPos[p1];
        player2.transform.position = SpawnPos[p2];
        player3.transform.position = SpawnPos[p3];

    }

    // Update is called once per frame
    void Update () {
		
	}
}
