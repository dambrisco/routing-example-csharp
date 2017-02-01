using System;
using Newtonsoft.Json;

namespace RoutingExample
{
  public class Program
  {
    public static void Main()
    {
      var route = (IRoute) new ExampleRoute();
      var json = @"{
        ""header"": ""hello"",
        ""obj"": {
          ""InStr"": ""world""
        }
      }";
      ExampleRequest request = JsonConvert.DeserializeObject<ExampleRequest>(json);
      string innerJson = JsonConvert.SerializeObject(request.Obj);
      object obj = JsonConvert.DeserializeObject(innerJson, route.GetParamType());
      object response = route.Handle(obj);
      string output = JsonConvert.SerializeObject(response);
      Console.WriteLine(output);
    }
  }

}
