using UnityEngine;

public class TransformController : MonoBehaviour
{
    
    private void Update()
    {
        // Move the target GameObject
        //var x = Mathf.PingPong(Time.time, 2);
        //var z = Mathf.PingPong(Time.time, 4);
        //var p = new Vector3(0, x, z);
        var x = Mathf.PingPong(Time.time, 2);
        var z = Mathf.PingPong(Time.time, 4);
        var p = new Vector3(0, x, z);
        transform.position = p;

        // Rotate the target GameObject
        //transform.Rotate(new Vector3(0, 60, 0) * Time.deltaTime);
    }
}