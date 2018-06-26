using UnityEngine;

public class CircleDestroyer : MonoBehaviour {

    public GameObject destructionPoint;

    // Use this for initialization
    void Start ()
    {
        destructionPoint = GameObject.Find("DestructionPoint");
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (transform.position.y < destructionPoint.transform.position.y)
        {
            Destroy(gameObject);
        }
    }
}
