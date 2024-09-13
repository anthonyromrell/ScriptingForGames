using UnityEngine;
public class SideMove : MonoBehaviour
{

    private void Update()
    {
        // Move the target GameObject
        var x = Mathf.PingPong(Time.time, 3);
        var p = new Vector3(x, 0, 0);
        transform.position = p;
        
    }
}