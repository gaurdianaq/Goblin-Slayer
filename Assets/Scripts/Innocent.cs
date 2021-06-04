using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Innocent : MonoBehaviour
{
    public float speed;
    private Vector3 newPosition;

    // Start is called before the first frame update
    void Start()
    {
        newPosition = transform.position;
    }

    private void FixedUpdate()
    {
        newPosition.x -= speed;
        transform.position = newPosition;
    }

    public void Kill()
    {
        Destroy(this.gameObject);
    }
}
