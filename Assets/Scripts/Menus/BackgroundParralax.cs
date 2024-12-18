using UnityEngine;

public class BackgroundParralax : MonoBehaviour
{
    public Rigidbody sprite;
    public float speed; // speeed at which the section moves
    Vector3 startPosition; // unused
    public float boundary; // boundary when to reset to other position
    public float resetState; // state it gets reset to
    // this handles the background parralex effect, this uses localPosition so be mindful of that
    void Start()
    {
        startPosition = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.localPosition;
        sprite.AddRelativeForce((speed * Time.deltaTime), 0, 0);
        //Debug.Log(transform.localPosition.x);
        if (transform.localPosition.x <= -resetState)
        {
            newPosition.x = boundary;
        }
        transform.localPosition = newPosition;
    }
}
