namespace RoutingExample
{
  class ExampleRoute : Route<ExampleParam, ExampleResponse>
  {
    override public ExampleResponse Handle(ExampleParam param)
    {
      return new ExampleResponse { OutStr = param.InStr };
    }
  }
}

