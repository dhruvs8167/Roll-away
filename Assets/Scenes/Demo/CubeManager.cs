using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeManager : MonoBehaviour {
    public GameObject[] cubeprefabs;
    public Text sc;
    public Text Finalsc;
    public float scorevalue;
    private Transform playerTransform;

    private float spawnZ = 0.0f;
    private float cubeLength = 82.0f;
    private int amonCubeOnScreen = 3;
    // Use this for initialization
  private  void Start() {
        playerTransform = GameObject.FindWithTag("player").transform;
        for (int i=0; i < amonCubeOnScreen; i++)
        {
            SpawnTile();
          
        }
  }
	
	// Update is called once per frame
	void Update () {
		if(playerTransform.position.z > (spawnZ - amonCubeOnScreen*cubeLength))
        {
            SpawnTile();
        }
        scorevalue = scorevalue + ((spawnZ)/2);
        sc.text = "Score: " + scorevalue;
        Finalsc.text = "Your Score: " + scorevalue;
    }
    public void Score()
    {
        scorevalue = scorevalue * 2;
    }
    private void SpawnTile(int prefabIndex = -1)
    {
        var number = Random.Range(0, 3);


        GameObject go;
        go = Instantiate(cubeprefabs[number]) as GameObject;
        go.transform.parent = transform;
        go.transform.position = Vector3.forward * spawnZ;
        spawnZ += cubeLength;
    }
}
