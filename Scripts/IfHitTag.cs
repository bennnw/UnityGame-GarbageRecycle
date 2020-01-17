using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IfHitTag : MonoBehaviour
{
    // Start is called before the first frame update

    private GameObject spawnPos;

    void Awake()
    {
        spawnPos = GameObject.Find("SpawnPos");
    }

    void OnTriggerEnter(Collider col)
    {
        GameObject trash = col.transform.gameObject;
        Vector3 trashPos = col.transform.position;
        if (col.tag[col.tag.Length - 1] != tag[tag.Length - 1])
        {
            float spawnX = spawnPos.transform.position.x;
            float spawnY = spawnPos.transform.position.y;
            float spawnZ = spawnPos.transform.position.z;
            col.transform.position = new Vector3(Random.Range(spawnX, spawnX + .6f), spawnY, Random.Range(spawnZ, spawnZ - .25f));
        }
        else
        {
            Destroy(col.transform.gameObject);
            GameObject eSystem = GameObject.FindWithTag("EventSystem");
            GameControl gameScore = eSystem.GetComponent<GameControl>();
            gameScore.score++;
        }
        //trashCan.transform.Rotate(Vector3.up * speed * 360);
        //}
    }

}
