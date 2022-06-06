using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{
    [System.Serializable]
    public class PooledThings
    {
        public GameObject objectToPool;
        public int numToPool;

        public List<GameObject> objectPoolList = new List<GameObject>();

        public GameObject GetPooledObject()
        {
            for (int i = 0; i < objectPoolList.Count; i++)
            {
                if (!objectPoolList[i].activeInHierarchy) // go to position 0 in list
                {
                    return objectPoolList[i];
                }
            }

            GameObject obj = (GameObject)Instantiate(objectToPool); // Uses casting
            obj.SetActive(false);
            objectPoolList.Add(obj); // Adding object to pooled Object List

            return obj;
        }
    }

    public PooledThings[] pools;

    // Start is called before the first frame update
    void Start()
    {
        PoolItems();
    }

    public void PoolItems()
    {
        for (int i = 0; i < pools.Length; i++)
        {
            Debug.Log("Pool: " + i);
            

            for (int a = 0; a < pools[i].numToPool; a++)
            {
                GameObject obj = (GameObject)Instantiate(pools[i].objectToPool); // Uses casting
                obj.SetActive(false);
                pools[i].objectPoolList.Add(obj); // Adding object to pooled Object List
            }
        }
    }

    public void GetPooledItem(int poolNumber)
    {
        pools[poolNumber].GetPooledObject();
    }
}
