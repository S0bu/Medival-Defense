using UnityEngine;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;

public class BattleShip : MonoBehaviour
{
    private bool isBoost = false;
    private bool isAttack = false;

    private bool gravity = true;
    private float gValue = 5.5f;
    
    private Vector2 touchLocation = Vector2.zero;

    void Start()
    {
        
    }

    void Update()
    {
        touchLocation = Touch.activeFingers[-1].screenPosition;


    }
}
