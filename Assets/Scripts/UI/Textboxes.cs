using UnityEngine;

public class Textboxes : MonoBehaviour
{
    private Rigidbody body;

    public float textboxSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        body = GetComponent<Rigidbody>();
        body.AddRelativeForce(0, (textboxSpeed * Time.deltaTime), 0, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
