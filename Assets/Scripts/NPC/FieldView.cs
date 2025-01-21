using UnityEngine;

public class FieldView : MonoBehaviour
{
    [SerializeField]
    private float fovAngle = 90f;
    [SerializeField]
    private Transform fovPoint;
    [SerializeField]
    private float range = 4;

    [SerializeField]
    private Transform target;

    private void Update()
    {
        Vector2 dir = target.position - transform.position;
        float angle = Vector3.Angle(dir, fovPoint.up);
        RaycastHit2D r = Physics2D.Raycast(fovPoint.position, dir, range);

        if(angle < fovAngle / 2)
        {
            if(Vector2.Distance(fovPoint.position, target.position) <= range)
            {
                //Debug.Log("Seen!");
                Debug.DrawRay(fovPoint.position, dir, Color.red);
            }
            else
            {
                //Debug.Log("Dont Seen");
            }
        }
    }
}
