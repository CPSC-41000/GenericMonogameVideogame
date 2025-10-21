using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToeJamAndEarlFirstBatch
{
    public abstract class Manager<Component>
    {
        public abstract void Create();
        public abstract void Destroy();

        List<Component> list;
        List<Manager<Component>> managers;
    }
}
