using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private Rigidbody body;
    public Sprite[] sprites;
    float _interval = 0.15f;
    float _time;
    public float textboxSpeed;
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
    }

    public void ChangeEmote(int emote)
    {
        spriteRenderer.sprite = sprites[emote];
    }
}
