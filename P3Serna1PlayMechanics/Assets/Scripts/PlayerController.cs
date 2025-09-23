using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public float speed = 5.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float fowardInput = Input.GetAxis("Verical");

        playerRb.AddForce(Vector3.forward * fowardInput * speed * fowardInput);
    }
}
