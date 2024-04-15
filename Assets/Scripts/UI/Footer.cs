using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomeUI : MonoBehaviour
{
    [SerializeField] Button _Nav;
    [SerializeField] Button _Prof;
    [SerializeField] Button _Hom;

    
    void Start()
    {
        _Nav.onClick.AddListener(_navbar);
        _Prof.onClick.AddListener(_profi);
        _Hom.onClick.AddListener(_Homi);
    }

    private void _navbar()
    {
        ScenesManager.Instance.LoadNav1flr2();
    }

    private void _profi()
    {
        ScenesManager.Instance.LoadProfile();
    }

    private void _Homi()
    {
        ScenesManager.Instance.LoadHome();
    }

}
