using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Counter : MonoBehaviour
{
    private VisualElement counter;
    private Label coinsLabel;
    public int coinsValue = 0;
    private void Start()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;
        counter = root.Q<VisualElement>("counter");
        coinsLabel = root.Q<Label>("counter-label");
    }

    private void Update()
    {
        coinsLabel.text = coinsValue.ToString();
    }
    public void AddValue()
    {
        coinsValue++;
    }
}
