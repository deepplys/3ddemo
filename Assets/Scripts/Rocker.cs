using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocker : MonoBehaviour
{
    public RectTransform rect;
    Vector2 startPos;
    Vector2 endPos;
    public float h, v;
    void Strat()
    {
        rect = gameObject.GetComponent<RectTransform>();
        startPos = rect.position;
    }
    void Update()
    {
        endPos = rect.position;
        Vector2 vec = endPos - startPos;
        h = vec.x;
        v = vec.y;
    }
}
