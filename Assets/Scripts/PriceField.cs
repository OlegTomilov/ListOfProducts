using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PriceField : MonoBehaviour
{
    [SerializeField] private TMP_InputField _text;
    [SerializeField] private CountField _countField;
    private float _priceOfProduct = 0;
    private float _tempPrice;

    private void OnEnable()
    {
        _priceOfProduct = ChangeParse();
        _countField.IncreasedCount += OnIncreased;
        _countField.DecreasedCount += OnDecreased;
    }

    private void OnDisable()
    {
        _countField.IncreasedCount -= OnIncreased;
        _countField.DecreasedCount -= OnDecreased;
    }

    public float ChangeParse()
    {
        float outputNumber;
        float.TryParse( _text.text, out outputNumber );
        return outputNumber;
    }

    private void OnIncreased()
    {
        if (_priceOfProduct > 0)
        {
            _priceOfProduct = ChangeParse();
            _tempPrice = _priceOfProduct;
            _tempPrice += _priceOfProduct;
            RefreshPrice(_priceOfProduct);
        }
    }

    private void OnDecreased()
    {
        if (_priceOfProduct > 0)
        {
            _tempPrice -= _priceOfProduct;
            RefreshPrice(_priceOfProduct);
        }
    }

    private void RefreshPrice(float _priceOfProduct)
    {
        _text.text = _tempPrice.ToString();
    }
}
