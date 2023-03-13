using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private Rigidbody targetRB;
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        
        targetRB = GetComponent<Rigidbody>();
        targetRB.AddForce(Vector3.up * Random.Range(12, 16), ForceMode.Impulse);
        targetRB.AddTorque(Random.Range(-10, 10), Random.Range(-10, 10), Random.Range(-10, 10), ForceMode.Impulse);
        transform.position = new Vector3(Random.Range(-4, 4), -6);
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }
    private void OnMouseDown()
    {
        Destroy(gameObject);
        gameManager.UpdateScore(5);
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
