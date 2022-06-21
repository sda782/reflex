using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimonSays : MonoBehaviour
{
    [SerializeField]
    private GameObject[] cubes;
    [SerializeField]
    private int numberOfGuesses;
    [SerializeField]
    private float delayTime;
    private float delayDelta;
    [SerializeField]
    private int guessTime;
    private int cubeIndex = 0;
    void Start()
    {
        delayDelta = delayTime;
    }

    void Update(){
        delayDelta -= Time.deltaTime;
        if(delayDelta <= 0)
        {
            delayDelta = delayTime;

        }
    }

    void Blink()
    {
        GameObject lamp = cubes[cubeIndex >= cubes.Length ? 0 : cubeIndex++].transform.GetChild(0).gameObject;

    }
    IEnumerator Countdown(int time)
    {
        float delta = 0;
        while(delta > time)
        {
            delta = Time.deltaTime;
            yield return null;
        }
    }
}
