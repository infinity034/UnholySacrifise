using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Zone : MonoBehaviour
{
    NPC npc;
    [SerializeField]
    private Image view;
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
        npc = GetComponentInParent<NPC>();
    }

    private void Start()
    {
        rotationView.rotation = directionView.rotation;
        VigilanceZise();
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
            VigilanceZise();
            interactable = true;
            playerSeen = npc.FieldView.PlayerSeen();
            if (PlayerSeen)
            {
                RotateToTarget(target);
            }
        }
        else if (collision.gameObject.CompareTag("Door"))
        {
            VigilanceZise();
            if (Vector2.Distance(directionView.position, collision.gameObject.transform.position) <= interactRange)
            {
                interaction = true;
                collision.gameObject.GetComponentInParent<MovableFurniture>().Use(GetComponentInParent<NPC>());
                //RotateToTarget(collision.gameObject.transform);
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
        view.fillAmount = npc.FieldView.viewAngle / 360;
        view.transform.localRotation = Quaternion.Euler(0, 0, npc.FieldView.viewAngle / 2f);
    }
}
