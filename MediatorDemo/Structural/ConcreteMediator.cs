using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDemo.Structural
{
  public class ConcreteMediator : Mediator
  {
    public Collegue1 Collegue1 { get; set; }
    public Collegue2 Collegue2 { get; set; }

    public override void Send(string message, Colleague colleague)
    {
      if(colleague == this.Collegue1)
      {
        this.Collegue1.HandleNotification(message);
      }
      else
      {
        this.Collegue2.HandleNotification(message);
      }
    }
  }
}
