using UnityEngine;
using UnityEngine.InputSystem;


public class InputTest : MonoBehaviour{

    public InputActionProperty inputprop1;

    void Start(){
        
    }

    void Update(){
        float finputprop1value = inputprop1.action.ReadValue<float>();
        Debug.Log(finputprop1value);
    }
}
