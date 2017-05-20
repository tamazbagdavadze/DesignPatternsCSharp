using System.Collections.Generic;

namespace Command
{
    internal class ControlUnit
    {
        private readonly List<Command> _commands = new List<Command>();
        private int _current;

        public void StoreCommand(Command command)
        {
            _commands.Add(command);
        }

        public void ExecuteCommand()
        {
            _commands[_current].Execute();
            _current++;
        }

        public void Undo(int levels)
        {
            for (var i = 0; i < levels; i++)
            {
                if (_current > 0)
                {
                    _commands[--_current].UnExecute();
                }
            }
        }

        public void Redo(int levels)
        {
            for (var i = 0; i < levels; i++)
            {
                if (_current < _commands.Count - 1)
                {
                    _commands[_current++].Execute();
                }
            }
        }
    }
}
