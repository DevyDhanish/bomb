using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Screen : MonoBehaviour
{
    public TextMeshProUGUI display;
    private Bomb bomb;

    private void Start()
    {
        bomb = GetComponent<Bomb>();
    }
    private void Update()
    {
        display.text = bomb.numString;
    }
}
