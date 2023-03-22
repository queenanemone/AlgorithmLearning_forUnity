using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonExample : MonoBehaviour
{
    private void Start() {
        Singleton.getInstance.Function();   
    }
}