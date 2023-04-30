using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
   public float  angulo;
   private float x, y, z, v0, sin, cos, t, tt, v0x,v0y,v0z;
   private float g = 10;

   private Vector3 s0;
   
    void Start()
    {
        angulo = angulo * Mathf.PI / 180;
        sin = Mathf.Sin(angulo);
        cos = Mathf.Cos(angulo);
        s0 = transform.position;
        tt = Mathf.Sqrt(((3 - s0.y) - (15 - s0.x) * Mathf.Tan(angulo)) / (-5)); //(3,15) é a posição da cesta
        v0 = (15 - s0.x) / (tt * Mathf.Cos(angulo));
        v0x = v0 * cos;
        v0y = v0 * sin;
        v0z = -s0.z / tt;
    }

    void Update()
    {
        t += Time.deltaTime;
        x = s0.x + v0x * t;
        y = s0.y + v0y * t - g * t * t / 2;
        z = s0.z + v0z * t;
        transform.position = new Vector3(x, y, z);
    }
}