using System.Collections.Generic;

namespace Models.Resumo
{


public class Paging
{
    public int total { get; set; }
}

public class Value
{
    public object id { get; set; }
    public string name { get; set; }
    public int results { get; set; }
}

public class AvailableFilter
{
    public string id { get; set; }
    public string name { get; set; }
    public string type { get; set; }
    public List<Value> values { get; set; }
}

public class Resumo
{
    public Paging paging { get; set; }
    public List<object> filters { get; set; }
    public List<AvailableFilter> available_filters { get; set; }
}

}
