public class NewBehaviourScript : MonoBehaviour

{
    public GameObject objectprefab;
    private Rigidbody2D rb;
    private int i;
    // Start is called before the first frame update
    void Start()
    {
        i = -3;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        for (int a = 0; a < 5; a++ )
        {
            Debug.Log(a);
            i += 5;
            int yaxis = UnityEngine.Random.Range(-2, 6);
            int rot = UnityEngine.Random.Range(0, 90);
            Vector2 pos = new Vector2(i, yaxis);
            Quaternion mut = Quaternion.Euler(0, 0, rot);
            Instantiate(objectprefab, pos, mut);
            gameObject.AddComponent<BoxCollider2D>();
            gameObject.AddComponent<Rigidbody2D>();
            rb.bodyType = RigidbodyType2D.Static;
            Thread.Sleep(3000);
        }
    }
}

