using System.Collections.Generic;

namespace Factory.Models
{
  public class Machine
  {
    public Machine()
    {
      this.JoinEntities = new HashSet<MachineEngineer>();
    }

    public int MachineId { get; set; }
    public string MachineName { get; set; }
    public int FactoryId {  get; set; }
    public virtual Factory Factory { get; set; }

    public virtual ICollection<MachineEngineer> JoinEntities { get; }
  }
}