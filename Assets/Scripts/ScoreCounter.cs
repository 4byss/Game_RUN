using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    [HideInInspector]
    public static float scoreCount;
    [HideInInspector]
    public static int scoreCountInInt;
    private float scorePerSecond;

    [HideInInspector]
    public static Text score;

    private void Awake()
    {
        scoreCount = 0f;
        scorePerSecond = 1f;
    }

    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreCount += scorePerSecond * (Time.deltaTime*8);
        scoreCountInInt = (int)scoreCount;
        score.text = "Score: " + scoreCountInInt;
    }
    



















}
