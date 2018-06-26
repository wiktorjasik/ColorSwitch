using UnityEngine;

public class CircleGenerator : MonoBehaviour
{

    public Transform generationPoint;
    public GameObject[] circles;
    public GameObject colorChanger;

    void Start()
    {
        GenerateCircle();
        GenerateCircle();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < generationPoint.position.y)
        {
            GenerateCircle();
        }        
    }

    void GenerateCircle()
    {
        int index = Random.Range(0, 3);
        transform.position = new Vector3(transform.position.x, transform.position.y + 4f, transform.position.z);
        Instantiate(circles[index], transform.position, transform.rotation);
        transform.position = new Vector3(transform.position.x, transform.position.y + 4f, transform.position.z);
        Instantiate(colorChanger, transform.position, transform.rotation);
    }
}
