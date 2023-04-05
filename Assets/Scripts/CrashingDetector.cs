using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CrashingDetector : MonoBehaviour
{
    [SerializeField] private ScoreCounter scoreCounter;

    private Vector3 _startPosition;

    private void Start()
    {
        _startPosition = transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("trigger");
        scoreCounter.ScoreText.text = $"{0}";
    }
}
