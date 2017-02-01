using System;

namespace RoutingExample
{
  interface IRoute
  {
    object Handle(object param);
    Type GetParamType();
  }
}
