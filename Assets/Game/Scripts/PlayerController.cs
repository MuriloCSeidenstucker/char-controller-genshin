using UnityEngine;

public class PlayerController : MonoBehaviour
{
    void Update()
    {
        var h = Input.GetAxisRaw("Horizontal");
        var v = Input.GetAxisRaw ("Vertical");

        Debug.Log($"h{h}, v{v}");
    }
}
