using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class conseguirPontos : MonoBehaviour
{
    int gemasSobrando;
    int gemasSobrandoOG;

    void OnTriggerEnter(Collider other){
        Destroy(gameObject);
        gemasSobrando = GameObject.FindGameObjectsWithTag("gemas").Length;
        gemasSobrandoOG = gemasSobrando;
        //pontuacao.gemas = gemasSobrandoOG - gemasSobrando + 1;
        pontuacao.gemas++;
        
    }
}
