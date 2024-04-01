using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateGameObject : MonoBehaviour
{
    private float timer = 2f;

    private void Start()
    {
        Invoke("DeactivateGameObjects", timer);
    }

    private void DeactivateGameObjects()
    {
        gameObject.SetActive(false);
    }
}
