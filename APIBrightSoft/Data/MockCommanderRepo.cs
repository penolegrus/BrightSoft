using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIBrightSoft.Data;
using APIBrightSoft.Models;

namespace APIBrightSoft.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        //класс, который позволяет локально создать объекты без бд

        //показать все созданные объекты
        //public IEnumerable<Command> GetAllCommands()
        //{
        //    var commands = new List<Command>
        //    {
        //        new Command(1, "Объект 1", "S-01", 100.25),
        //        new Command(2, "Объект 2", "S-02", 150),
        //        new Command(3, "Объект 3", "S-QWE", 99.678)
        //    };
        //    return commands;
        //}

        //public Command GetCommandById(int id)
        //{
        //    return new Command(id, "Объект 1", "S-01", 100.25);
        //}
        public IEnumerable<Command> GetAllCommands()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SecondTable> GetAllCommands2()
        {
            throw new NotImplementedException();
        }

        public Command GetCommandById(int id)
        {
            throw new NotImplementedException();
        }

        public SecondTable GetCommandById2(int id)
        {
            throw new NotImplementedException();
        }
    }
}
