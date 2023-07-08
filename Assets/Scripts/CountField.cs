using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class CountField : MonoBehaviour
{
    [SerializeField] TMP_Text _output;

    private int _count;

    public event UnityAction IncreasedCount;
    public event UnityAction DecreasedCount;

    private void Start()
    {
        _count = 1;
    }

    public void Increase()
    {
        _count++;
        _output.text = _count.ToString();
        IncreasedCount.Invoke();
    }

    public void Decrease()
    {
        if(_count > 1)
        {
            _count--;
            _output.text = _count.ToString();
            DecreasedCount.Invoke();
        }
    }
}
