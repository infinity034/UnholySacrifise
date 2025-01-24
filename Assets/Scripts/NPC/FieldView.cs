using UnityEngine;

public class FieldView : MonoBehaviour
{
    private CapsuleCollider2D collider2D;
    [SerializeField]
    private float angleView = 90f;
    [SerializeField]
    private Transform directionView;
    [SerializeField]
    private float range = 4;
    [SerializeField]
    private int vigilancelevel = 1;

    [SerializeField]
    private Transform target;

    [SerializeField]
    private float[] offsetMin, offsetMax, sizeMin, sizeMax;

    public Transform DirectionView { get {  return directionView; } }

    private void Awake()
    {
        collider2D = GetComponent<CapsuleCollider2D>();
        target = FindObjectOfType<PlayerController>().transform;
    }

    private void Start()
    {
        Rotation(true,true);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Enter");
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Vector2 dir = target.position - transform.position;
            float angle = Vector3.Angle(dir, directionView.up);
            RaycastHit2D r = Physics2D.Raycast(directionView.position, dir, range);

            if (angle < angleView / 2)
            {
                if (Vector2.Distance(directionView.position, target.position) <= range)
                {
                    Debug.Log("Seen!");
                    Debug.DrawRay(directionView.position, dir, Color.red);
                }
                else
                {
                    Debug.Log("Dont Seen");
                }
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Exit");
        }
    }

    private float CurrentValueByAngle(float min, float max, float currentAngle)
    {
        float diff = max - min;

        float percentBetween = 0;
        if (currentAngle > 0f && currentAngle <= 90f) 
        {
            percentBetween = diff / 90f;
            return min + (percentBetween * currentAngle);
        }
        else if(currentAngle > 90f && currentAngle <= 180)
        {
            percentBetween = diff / 90f;
            return min + (diff - ((percentBetween * currentAngle) - diff));
        }
        else if (currentAngle > 180f && currentAngle <= 270f)
        {
            percentBetween = diff / 90f;
            return min + (percentBetween * (currentAngle - 180f));
        }
        else if (currentAngle > 270f && currentAngle <= 360)
        {
            percentBetween = diff / 90f;
            return min + (diff - ((percentBetween * (currentAngle - 180f)) - diff));
        }
        return 0;
    }

    public void Rotation(bool right, bool start = false)
    {
        Vector3 rotation = directionView.localEulerAngles;
        if(!start)
        {
            if (right)
            {
                rotation.z -= Time.deltaTime * 25;
            }
            else
            {
                rotation.z += Time.deltaTime * 25;
            }
        }
        directionView.localEulerAngles = rotation;
        collider2D.offset = new Vector2(0, CurrentValueByAngle(offsetMin[vigilancelevel], offsetMax[vigilancelevel], rotation.z));
        collider2D.size = new Vector2(1, CurrentValueByAngle(sizeMin[vigilancelevel], sizeMax[vigilancelevel], rotation.z));
    }
}
