using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Counter : MonoBehaviour
{
    // Start is called before the first frame update
    private VisualElement counter;
    private Label counterLabel;
    public int counterValue = 0;
    private void Start()
    {
        counterValue -= 10;
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;
        counter = root.Q<VisualElement>("counter");
        counterLabel = root.Q<Label>("counter-label");
    }

    private void Update()
    {
        counterLabel.text = counterValue.ToString();
    }
    public void AddValue()
    {
        counterValue++;
    }
}
