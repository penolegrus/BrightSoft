using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIBrightSoft.Data;
using APIBrightSoft.DOts;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIBrightSoft.Controllers
{
    [Route("api/commands")]
    [ApiController]
    public class CommandController : ControllerBase
        
    {
        //создаем конструктор и мапер
        private readonly ICommanderRepo _repository;
        private readonly IMapper _mapper;

        public CommandController(ICommanderRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        
        //GET api/commands
        [HttpGet]
        //вывести все данные из первой таблицы
        public ActionResult <IEnumerable<CommandReadDTO>> GetAllCommands()
        {
            var commandItems = _repository.GetAllCommands();
            return Ok(_mapper.Map<IEnumerable<CommandReadDTO>>(commandItems));
        }

        //GET api/commands/{id}
        [HttpGet("{id}")]
        //вывести строку из таблицы по айди
        public ActionResult <CommandReadDTO> GetCommandById(int id)
        {
            var commandItem = _repository.GetCommandById(id);
            if(commandItem != null)
            {
                return Ok(_mapper.Map<CommandReadDTO>(commandItem));

            }
            return NotFound();
        }




        // PUT api/<CommandController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CommandController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
