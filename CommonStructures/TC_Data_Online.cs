using System.Collections.Generic;

namespace CommonStructures
{
     public class TC_Data_Online
     {
          public List<List<ResultSetItemItem>> ResultSet { get; set; }
     }

     public class ResultSetItemItem
     {
          public string Name { get; set; }
          public Value Value { get; set; }
     }

     public class Value
     {
          public string Type { get; set; }
          public string Literal { get; set; }
     }
}
