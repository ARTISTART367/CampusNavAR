using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProfileUI : MonoBehaviour
{
    [SerializeField] Button _Sup;
    [SerializeField] Button _log;

    
    void Start()
    {
        _Sup.onClick.AddListener(_sin);
        _log.onClick.AddListener(_logo);
    }

    private void _logo()
    {
        ScenesManager.Instance.LoadLogin();
    }

    private void _sin()
    {
        ScenesManager.Instance.LoadSignup();
    }
}
