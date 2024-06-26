using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Timer : MonoBehaviour
{
    private VisualElement timer;
    private Label timerLabel;
    public double timerValue = 0.0f;
    private void Start()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;
        timer = root.Q<VisualElement>("timer");
        timerLabel = root.Q<Label>("timer-label");
    }

    // Update is called once per frame
    void Update()
    {
        timerValue += Time.deltaTime;
        timerValue = Math.Round(timerValue, 2);
        timerLabel.text = timerValue.ToString();
    }
}
