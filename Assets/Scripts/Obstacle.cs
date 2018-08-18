using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour {
    // Movement Speed (0 means don't move)
    public float speed = 0;
    private bool usado;
    private GameObject pontuacao;
    void Start()
    {
        Destroy(gameObject, 9f);
        GetComponent<Rigidbody2D>().velocity = Vector2.left * speed;
        usado = false;
        pontuacao = GameObject.FindGameObjectWithTag("Ponto");

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(!usado && collision.gameObject.tag == "Player")
        {
            pontuacao.GetComponent<pontos>().pontuacao += 1;
            usado = true;
            GetComponent<AudioSource>().Play();
        }
    }
}
