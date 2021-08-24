using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Enemy : MonoBehaviour
{
    [SerializeField] private int damageAmount = 1;
    [SerializeField] private ParticleSystem collisionParticles = null;
    [SerializeField] private AudioClip collisionSound = null;

    private Rigidbody rb;

    private void Awake()
    {
        this.rb = GetComponent<Rigidbody>();
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        Player player = other.gameObject.GetComponent<Player>();
        if (player == null)
        {
            return;
        }
        this.PlayerImpact(player);
        this.ImpactFeedback();
    }

    private void PlayerImpact(Player player)
    {

    }

    private void ImpactFeedback()
    {

    }
}
