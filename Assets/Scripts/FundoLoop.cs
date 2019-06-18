using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FundoLoop : MonoBehaviour
{
    private Renderer back;
    public float VelocidadeTransicao;
    private string nomeBack;

    void Start()
    {
        back = GetComponent<Renderer>();
        nomeBack = this.gameObject.tag;
    }

    void Update()
    {
       Vector2 offset = new Vector2(VelocidadeTransicao * Time.deltaTime, 0);

        back.material.mainTextureOffset += offset;
    }
}

/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FundoLoop : MonoBehaviour
{
    private Renderer back;
    private float vel;
    public float VelocidadeTransicaol;
    private string nomeBack;

    void Start()
    {
        back = GetComponent<Renderer>();
        nomeBack = this.gameObject.tag;
    }

    void Update()
    {
        switch (nomeBack)
        {
            case "NuvemMenu":
                vel = VelocidadeTransicao;
                break;
        }

        Vector2 offset = new Vector2(vel * Time.deltaTime, 0);

        back.material.mainTextureOffset += offset;
    }
}
*/