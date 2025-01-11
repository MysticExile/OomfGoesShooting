using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Textboxes : MonoBehaviour
{
    private Rigidbody body;
    float _interval = 3f;
    float _time;
    private int lineCounter = 0;
    public string[] script;
    public string levelName;
    public Vector2 floatY;
    public float FloatStrength;

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
        floatY = transform.position;
        floatY.y = (Mathf.Sin(Time.time) * FloatStrength + 1050);
        transform.position = floatY;
    }

    public void GoNext()
    {
        if(lineCounter < script.Length)
        {
            dialogue.text = script[lineCounter];
            lineCounter += 1;
        }
        else
        {
            lineCounter += 1;
            SceneManager.LoadScene(levelName);
        }
    }
}