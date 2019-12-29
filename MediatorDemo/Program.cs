using System;
using MediatorDemo.Structural;

namespace MediatorDemo
{
  class Program
  {
    static void Main(string[] args)
    {
      var mediator = new ConcreteMediator();
      var c1 = new Collegue1(mediator); // collegues referencing mediator
      var c2 = new Collegue2(mediator);
      mediator.Collegue1 = c1; // letting mediator know about its collegues
      mediator.Collegue2 = c2;

      c1.Send("Hello, World! (from c1)");
      c2.Send("Hello, World! (from c2)");
    }
  }
}
