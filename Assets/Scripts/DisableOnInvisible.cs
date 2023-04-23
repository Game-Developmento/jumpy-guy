using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableOnInvisible : MonoBehaviour
{
    private void OnBecameInvisible() {
        gameObject.SetActive(false);
    }
}
