using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI numberGuessd;
    int guess;

    void Start()
    {
        Debug.Log("Highest number is: " + max);
        Debug.Log("Lowest number is: " + min);
        max = max + 1;
        guess = Random.Range(min, max);
        numberGuessd.text = guess.ToString();
    }

    void NextGuess()
    {
        guess = Random.Range(min, max);
        Debug.Log("New guess is " + guess);
        numberGuessd.text = guess.ToString();
    }

    public void onPressHigher()
    {
        if(max - min > 1)
            min = guess + 1;
        NextGuess();
    }

    public void onPressLower()
    {
        if(max - min > 1)
            max = guess - 1;
        NextGuess();
    }


}