using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class pontuacao : MonoBehaviour
{
    public GameObject pTexto;
    public static int gemas;

    // Update is called once per frame
    void Update()
    {
        pTexto.GetComponent<TMPro.TextMeshProUGUI>().text = "Inventário tem " + gemas + " gemas verdes";
    }
}
