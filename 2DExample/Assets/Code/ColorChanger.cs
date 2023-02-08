using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public Color[] colors;

    private void Awake()
    {
        
    }
    void Start()
    {
        foreach (Color color in colors)
        {
            Debug.Log(color);
        }
    }

    void Update()
    {

    }
}
