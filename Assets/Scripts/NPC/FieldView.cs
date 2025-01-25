using UnityEngine;
using UnityEngine.UI;

public class FieldView : MonoBehaviour
{
    [SerializeField]
    private Image view;
    [SerializeField]
    private float angleView = 90f, angleInteraction = 10f;
    [SerializeField]
    private Transform directionView, rotationView, zone, zoneView;
    [SerializeField]
    private float range = 10f, interactRange = 1f;
    [SerializeField]
    private int vigilancelevel = 1;

    [SerializeField]
    private Transform target;

    [SerializeField]
    private float[] size;

    [SerializeField]
    private bool playerSeen, interaction, interactable;

    public Transform DirectionView { get {  return directionView; } }
    public Transform Target { get { return target; } }
    public bool PlayerSeen { get { return playerSeen; } }
    public bool Interaction { get { return interaction; } set { interaction = value; } }
    public bool Interactable { get { return interactable; } }

    private void Awake()
    {
        target = FindObjectOfType<PlayerController>().transform;
    }

    private void Start()
    {
        VigilanceZise();
        rotationView.rotation = directionView.rotation;
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
            interactable = true;
            VigilanceZise();
            Vector2 dir = collision.gameObject.transform.position - directionView.position;
            float angle = Vector3.Angle(dir, directionView.up);
            RaycastHit2D r = Physics2D.Raycast(directionView.position, dir, range);

            if (angle < angleView / 2)
            {
                if (Vector2.Distance(directionView.position, collision.gameObject.transform.position) <= range)
                {
                    playerSeen = true;
                    Debug.DrawRay(directionView.position, dir, Color.red);
                    RotateToTarget(collision.gameObject.transform);
                }
                else
                {
                    playerSeen = false;
                }
            }
            else
            {
                playerSeen = false;
            }
        }
        else if (collision.gameObject.CompareTag("Door"))
        {
            VigilanceZise();
            Vector2 dir = collision.gameObject.transform.position - directionView.position;
            float angle = Vector3.Angle(dir, directionView.up);
            RaycastHit2D r = Physics2D.Raycast(directionView.position, dir, interactRange);

            if (angle < angleInteraction / 2)
            {
                if (Vector2.Distance(directionView.position, collision.gameObject.transform.position) <= interactRange)
                {
                    interaction = true;
                    Debug.DrawRay(directionView.position, dir, Color.red);
                    collision.gameObject.GetComponentInParent<MovableFurniture>().Use(GetComponentInParent<NPC>());
                    //RotateToTarget(collision.gameObject.transform);
                }
            }
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerSeen = false;
            interactable = false;
            Debug.Log("Exit");
        }
    }

    public void RotationView(Quaternion targetRotation)
    {
        directionView.rotation = Quaternion.RotateTowards(directionView.rotation, targetRotation, 1000 * Time.deltaTime);
        rotationView.rotation = Quaternion.RotateTowards(rotationView.rotation, targetRotation, 1000 * Time.deltaTime);
    }

    public void RotateToTarget(Transform target)
    {
        Transform body = GetComponentInParent<NPC>().Body;
        float angle = Mathf.Atan2(target.position.y - body.position.y, target.position.x - body.position.x) * Mathf.Rad2Deg;
        Quaternion targetRotation = Quaternion.Euler(new Vector3(0, 0, angle - 90));
        RotationView(targetRotation);
    }

    private void VigilanceZise()
    {
        zone.localScale = new Vector3(size[vigilancelevel], size[vigilancelevel], size[vigilancelevel]);
        zoneView.localScale = new Vector3(size[vigilancelevel], size[vigilancelevel], size[vigilancelevel]);
        view.fillAmount = angleView / 360;
        view.transform.localRotation = Quaternion.Euler(0, 0, angleView / 2f);
    }
}
