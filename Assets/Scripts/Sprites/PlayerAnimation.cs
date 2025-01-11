using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private Rigidbody body;
    public Sprite[] sprites;
    float _interval = 0.15f;
    float _time;
    public Vector3 floatZ;
    public float FloatStrength;
    public int startSprite;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = sprites[startSprite];
    }

    void Update()
    {
        _time += Time.deltaTime;
        while (_time >= _interval)
        {
            if (spriteRenderer.sprite == sprites[3])
            {
                spriteRenderer.sprite = sprites[2];
            }
            else if (spriteRenderer.sprite == sprites[2])
            {
                spriteRenderer.sprite = sprites[3];
            }
            _time -= _interval;
        }
        Bobbing();
    }

    public void ChangeEmote(int emote)
    {
        spriteRenderer.sprite = sprites[emote];
    }

    void Bobbing()
    {
        floatZ = transform.position;
        floatZ.z = (Mathf.Sin(Time.time) * FloatStrength);
        transform.position = floatZ;
    }
}
