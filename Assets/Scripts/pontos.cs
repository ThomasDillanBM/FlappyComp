using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pontos : MonoBehaviour {

    public int pontuacao;
    public UnityEngine.UI.Text textoPontos;
	// Use this for initialization
	void Start ()
    {
        pontuacao = 0;	
	}
	
	// Update is called once per frame
	void Update () {
        textoPontos.text = pontuacao.ToString();
	}
}
