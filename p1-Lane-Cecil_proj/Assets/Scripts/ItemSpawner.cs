using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    public GameObject[] collectableTypes;
    [SerializeField] private int collectablesToSpawn = 99;
    [SerializeField] private float timeToNextSpawn = 1f;
    public GameObject quad;

    private void Start()
    {
        StartCoroutine("SpawnCollectables");
    }
    public IEnumerator SpawnCollectables()
    {
        int randomItemType = 0;
        GameObject itemToSpawn;

        MeshCollider c = quad.GetComponent<MeshCollider>();
        float screenX, screenY;
        Vector2 pos;
 

        for (int i = 0; i < collectablesToSpawn; i++)
        {
            //Select collectable type
            randomItemType = Random.Range(0, collectableTypes.Length);
            itemToSpawn = collectableTypes[randomItemType];

            screenX = Random.Range(c.bounds.min.x, c.bounds.max.x);
            screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
            pos = new Vector2(screenX, screenY);

            Instantiate(itemToSpawn, pos, transform.rotation);
            collectablesToSpawn--;
            yield return new WaitForSeconds(timeToNextSpawn);
        }
    }
}