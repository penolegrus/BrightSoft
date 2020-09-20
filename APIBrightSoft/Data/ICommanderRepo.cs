using APIBrightSoft.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIBrightSoft.Data
{
    public interface ICommanderRepo
    {
      
        //интерфейс
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id);


        IEnumerable<SecondTable> GetAllCommands2();
        SecondTable GetCommandById2(int id);



    }
}
