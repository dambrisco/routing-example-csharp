using System;

namespace RoutingExample
{
  abstract class Route<TIn, TOut> : IRoute
    where TIn : class
  {
    public abstract TOut Handle(TIn param);

    public object Handle(object param)
    {
      return Handle(param as TIn);
    }

    public Type GetParamType()
    {
      return typeof(TIn);
    }
  }
}
