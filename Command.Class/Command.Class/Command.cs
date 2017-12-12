using System;
namespace Command.Class
{
    abstract class Command

    {
        public abstract void Execute();
        public abstract void UnExecute();
    }
}
