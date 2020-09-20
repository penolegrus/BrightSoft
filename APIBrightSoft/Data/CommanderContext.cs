using APIBrightSoft.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIBrightSoft.Data
{
    public class CommanderContext : DbContext
    {
        //подключаемся к бд
        public CommanderContext(DbContextOptions<CommanderContext> opt) : base(opt)
        {

        }
        //определяем таблицы из бд
        public DbSet<Command> BuildObject { get; set; }
        public DbSet<SecondTable> BuilVersion { get; set; }
        public DbSet<ThirdTable> TypeVersions { get; set; }

    }
}
