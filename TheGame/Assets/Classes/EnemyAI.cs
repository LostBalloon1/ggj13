using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {

    public Transform[] nodes;
    public float moveSpeed = 1.0f;

    private int CurrentNodeIndex = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (nodes.Length > 0 && CurrentNodeIndex < nodes.Length) {
            Vector3 destination = nodes[CurrentNodeIndex].position;
            Vector3 move = new Vector3(destination.x - transform.position.x, destination.y - transform.position.y, 0);
            float moveNorm = Mathf.Sqrt(move.x * move.x + move.y * move.y);
            Vector3 moveUnit = new Vector3(move.x / moveNorm, move.y / moveNorm, 0);

            transform.position += new Vector3(Time.deltaTime * moveSpeed * moveUnit.x, Time.deltaTime * moveSpeed * moveUnit.y, 0);
        }
	}

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "NavNodes")
        {
            IncrementNode();
            Debug.Log("a");
        }
        Debug.Log("b");
    }

    public void IncrementNode()
    {
        CurrentNodeIndex++;
    }
}
