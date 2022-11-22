using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangerObjects : MonoBehaviour
{
    public float speed = 7f;
    public int damage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Collided with an object");
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
