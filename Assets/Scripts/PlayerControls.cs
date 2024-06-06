using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControls : MonoBehaviour
{
    [Header("Rigidbody")] 
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Time.timeSCale = 1f;

    }

    // Update is called once per frame
    void Update()
    {

    }
}
