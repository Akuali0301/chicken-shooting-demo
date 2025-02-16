using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    //Instance
    private static InputManager instance;
    public static InputManager Instance { get => instance; }

    //Current mouse pos
    [SerializeField] protected Vector3 mouseWorldPos;
    public Vector3 MouseWorldPos { get => mouseWorldPos; }



    //Position when right click
    protected Vector3 mouseRightClickPos;
    public Vector3 MouseRightClickPos { get => mouseRightClickPos; }


    private void Awake()
    {
        if (InputManager.instance != null) Debug.LogError("Only 1 InputManager allow");
        InputManager.instance = this;
    }


    private void Update()
    {
      
    }

    void FixedUpdate()
    {
        this.GetMousePos();
    }

    protected virtual void GetMousePos()
    {
        this.mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }


    protected virtual void GetMouseRightClickPos()
    {
        if (Input.GetMouseButtonDown(1)) // 1 is right click
        {
            this.mouseRightClickPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
    }

}
