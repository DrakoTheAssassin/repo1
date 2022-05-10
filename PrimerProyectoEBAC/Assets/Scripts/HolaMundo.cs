using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolaMundo : MonoBehaviour
{
    // Start is called before the first frame update
    private void Awake()
    {
        print("algo paso");
        Debug.Log("algo paso");
        Debug.LogWarning("Algo salio medianamente mal");
        Debug.LogError("Algo salio muy mal");
    }
    void Start()
    {
        print("algo paso");
        Debug.Log("algo paso");
        Debug.LogWarning("Algo salio medianamente mal");
        Debug.LogError("Algo salio muy mal");
    }

    // Update is called once per frame
    void Update()
    {
        print("algo paso");
        Debug.Log("algo paso");
        Debug.LogWarning("Algo salio medianamente mal");
        Debug.LogError("Algo salio muy mal");
    }

    private void FixedUpdate()
    {
        print("algo paso");
        Debug.Log("algo paso");
        Debug.LogWarning("Algo salio medianamente mal");
        Debug.LogError("Algo salio muy mal");
    }

    private void LateUpdate()
    {
        print("algo paso");
        Debug.Log("algo paso");
        Debug.LogWarning("Algo salio medianamente mal");
        Debug.LogError("Algo salio muy mal");
    }
}
