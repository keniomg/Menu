using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System;

public class Menu : MonoBehaviour
{
    public void OnOpenMenuButtonClicked()
    {
        gameObject.SetActive(true);
    }

    public void OnCloseMenuButtonClicked()
    {
        gameObject.SetActive(false);
    }
}