using UnityEngine;

public class Rotator : MonoBehaviour {

    public float rotationSpeed = 100f;
    public float dir = 1f;

    private void Start()
    {
        rotationSpeed = Random.Range(100f, 200f);
        dir = Random.Range(-1f, 1f);
        if (dir < 0)
            dir = -1;
        else
            dir = 1;
    }

    // Update is called once per frame
    void Update ()
    {
        transform.Rotate(0f, 0f, rotationSpeed * dir * Time.deltaTime);
	}
}
