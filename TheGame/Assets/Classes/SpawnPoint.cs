using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpawnPoint : MonoBehaviour {

    private List<List<GameObject>> myArray = new List<List<GameObject>>();
    public GameObject[] prefabs;
    public float waveIntervalInSeconds = 30.0f;

	// Update is called once per frame
	void Update () {
        //Example();
	}

    //void Example()
    IEnumerator Example()
    {
        int index = 0;
        int listindex = 0;
        //Debug.Log(myArray.Count);
        //Debug.Log(myArray[0].Count);
        for (int i = 0; i < myArray.Count; i++)
        {
            for (int j = 0; j < myArray[i].Count; j++)
            {
                Instantiate(myArray[listindex][index], transform.position, Quaternion.identity);
                yield return new WaitForSeconds(0.5f);
            }
            yield return new WaitForSeconds(waveIntervalInSeconds);
        }
    }

    // Use this for initialization
    void Start()
    {
        List<GameObject> list1 = new List<GameObject>();
        list1.Add(prefabs[0]);
        list1.Add(prefabs[0]);
        list1.Add(prefabs[0]);
        list1.Add(prefabs[0]);
        list1.Add(prefabs[0]);
        list1.Add(prefabs[0]);
		list1.Add(prefabs[0]);
		list1.Add(prefabs[0]);
		list1.Add(prefabs[0]);
		list1.Add(prefabs[0]);
		list1.Add(prefabs[0]);
		list1.Add(prefabs[0]);
		list1.Add(prefabs[0]);
		list1.Add(prefabs[0]);
		list1.Add(prefabs[0]);
		list1.Add(prefabs[0]);
		list1.Add(prefabs[0]);
		list1.Add(prefabs[0]);
		list1.Add(prefabs[0]);
		list1.Add(prefabs[0]);
		list1.Add(prefabs[0]);
		list1.Add(prefabs[0]);
		list1.Add(prefabs[0]);
        myArray.Add(list1);

        List<GameObject> list2 = new List<GameObject>();
        list2.Add(prefabs[0]);
        list2.Add(prefabs[0]);
        list2.Add(prefabs[0]);
        list2.Add(prefabs[0]);
        list2.Add(prefabs[0]);
        list2.Add(prefabs[0]);
        list2.Add(prefabs[0]);
        list2.Add(prefabs[0]);
        list2.Add(prefabs[0]);
        list2.Add(prefabs[0]);
        list2.Add(prefabs[0]);
        list2.Add(prefabs[0]);
        myArray.Add(list2);

        StartCoroutine(Example());
    }
}
