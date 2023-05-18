using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DispalayScore : MonoBehaviour
{
    public TextMeshPro textMeshPro;
    public static int score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        textMeshPro.text = score.ToString();
    }
}
