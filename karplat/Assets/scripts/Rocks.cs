using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocks : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == Character.Instance.gameObject)
        {
            Character.Instance.GetDamage();
        }
    }
}
