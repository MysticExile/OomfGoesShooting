using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Textboxes : MonoBehaviour
{
    private Rigidbody body;
    private bool alternate = true;
    private bool cooldown = true;
    float _interval = 3f;
    float _time;
    private int lineCounter = 1;

    public float textboxSpeed;
    public TextMeshProUGUI dialogue;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        body = GetComponent<Rigidbody>();
        body.AddRelativeForce(0, (textboxSpeed * Time.deltaTime), 0, ForceMode.Impulse);
        _time = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        _time += Time.deltaTime;
        while (_time >= _interval)
        {
            GoNext();
            _time -= _interval;
        }
        Bobbing();
    }

    void Bobbing()
    {
        if (body.transform.localPosition.y > 10.0f)
        {
            body.AddRelativeForce(0, (-textboxSpeed * Time.deltaTime), 0, ForceMode.Impulse);
            Debug.Log(body.transform.localPosition.y);
        }
        if (body.transform.localPosition.y < -10)
        {
            body.AddRelativeForce(0, (textboxSpeed * Time.deltaTime), 0, ForceMode.Impulse);
        }
    }

    void GoNext()
    {
        switch ((lineCounter))
        {
            case (1):
                dialogue.text = "U ok??";
                lineCounter += 1;
                break;
            case (2):
                dialogue.text = "I saw the gc\nU good?";
                lineCounter += 1;
                break;
            case (3):
                dialogue.text = "Just know that\nI'm ur oomf";
                lineCounter += 1;
                break;
            case (4):
                dialogue.text = "And I'll always\nBe there 4 u xoxo";
                lineCounter += 1;
                break;
            case (5):
                lineCounter += 1;
                SceneManager.LoadScene("level1");
                break;
            default:
                break;
        }


    }
}