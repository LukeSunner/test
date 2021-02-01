using UnityEngine;

public class ObjectName : MonoBehaviour
{
    public string objName;
    public void Start()
    {
        if (objName == "")
        {
            objName = "Nameless one";
        }
    }

    // Update is called once per frame
    void Update()
    {
        print(gameObject.name);
    }
}
