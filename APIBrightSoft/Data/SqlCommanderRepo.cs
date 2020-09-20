using APIBrightSoft.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIBrightSoft.Data
{
    public class SqlCommanderRepo : ICommanderRepo
    {
        //Определяем бд
        private readonly CommanderContext _context;

        public SqlCommanderRepo(CommanderContext context)
        {
            _context = context;
        }
        //возвращаем все объекты из 1 таблицы из бд
        public IEnumerable<Command> GetAllCommands()
        {
            return _context.BuildObject.ToList();
        }

        //возвращаем определенный объект из бд по айди
        public Command GetCommandById(int id)
        {
            return _context.BuildObject.FirstOrDefault(p => p.Id == id);
        }

        //вторая таблица
        //возвращаем все объекты из 2 таблцы из бд
        public IEnumerable<SecondTable> GetAllCommands2()
        {
            return _context.BuilVersion.ToList();
        }
        //возвращаем определенный объект из бд по айди
        public SecondTable GetCommandById2(int id)
        {
            return _context.BuilVersion.FirstOrDefault(p => p.Id == id);
        }

    }
}
