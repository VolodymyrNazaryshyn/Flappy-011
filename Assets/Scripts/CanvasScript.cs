using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasScript : MonoBehaviour
{
    [SerializeField]
    private TMPro.TextMeshProUGUI Clock;

    private float gameTime;

    void Start()
    {
        Clock.text = "";
        gameTime = 0;
    }

    void Update()
    {
        gameTime += Time.deltaTime;

        Clock.text = (((int)(gameTime * 10))/10f).ToString();
    }
}
