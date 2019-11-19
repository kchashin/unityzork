using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using zork.common;

public class UnityOutputService : MonoBehaviour, IOutputService
{
    [SerializeField]
    private TextMeshProUGUI TextLinePrefab;

    [SerializeField]
    private Transform OutputTextContainer;

    [SerializeField]
    private int MaxTextLine = 60;

    public UnityOutputService()
    {
        mTextLines = new List<GameObject>();
    }
    public void Clear()
    {
        throw new System.NotImplementedException();
    }

    public void Write(string value)
    {
        throw new System.NotImplementedException();
    }

    public void Write(object value)
    {
        throw new System.NotImplementedException();
    }

    public void WriteLine(string value)
    {

        if(mTextLines.Count >= MaxTextLine)
        {
            Destroy(mTextLines[0]);
            mTextLines.RemoveAt(0);
        }
        var textLine = Instantiate(TextLinePrefab);
        textLine.transform.SetParent(OutputTextContainer, false);
        textLine.text = value;
        mTextLines.Add(textLine.gameObject);
        //TextLinePrefab.text = value;
       
    }

    public void WriteLine(object value)
    {
        throw new System.NotImplementedException();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private List<GameObject> mTextLines;


}
