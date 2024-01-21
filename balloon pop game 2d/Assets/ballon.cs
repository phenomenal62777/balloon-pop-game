using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class ballon : MonoBehaviour
{
    int score = 0;
    public float speed;
    AudioSource auidosource;
    public TextMeshProUGUI textsc;
    // Start is called before the first frame update
    private void Awake()
    {
        auidosource = GetComponent<AudioSource>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > 7)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    private void FixedUpdate()
    {
        transform.Translate(0, speed, 0);
    }
    private void OnMouseDown()
    {
        score++;
        textsc.text = score.ToString();
        auidosource.Play();
        randompos();
    }
    private void randompos() 
    {
        float randomx = Random.Range(-2.5f, 2.5f);
        transform.position = new Vector2(randomx, -7f);
    }

}
