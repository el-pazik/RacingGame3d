using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CrashingDetector : MonoBehaviour
{
    [SerializeField] private ScoreCounter scoreCounter;
    [SerializeField] private HealthCounter healthCounter;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Coin")
        {
            scoreCounter.Score += 10;
        }
        else if(other.gameObject.tag == "HealthPoint")
        {
            healthCounter.Health += 1;
        }
        else
        {
            healthCounter.Health--;
        }
    }
}
