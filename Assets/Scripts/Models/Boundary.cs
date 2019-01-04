using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class Range
{
    public float min, max;
}

[System.Serializable]
public class Boundary
{
    public Range x;
    public Range z;
    
}