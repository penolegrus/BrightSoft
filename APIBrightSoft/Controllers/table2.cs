using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIBrightSoft.Data;
using APIBrightSoft.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIBrightSoft.Controllers
{
    [Route("api/table2")]
    [ApiController]
    public class table2 : ControllerBase
        
    {
        //создаем конструктор и мапер
        private readonly ICommanderRepo _repository;
        private readonly IMapper _mapper;
        public table2(ICommanderRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        //GET api/table2
        [HttpGet]
        //вывести все данные из 2 таблицы
        public ActionResult<IEnumerable<SecondTableDTO>> GetAllCommands2()
        {
            var commandItems = _repository.GetAllCommands2();
            return Ok(_mapper.Map<IEnumerable<SecondTableDTO>>(commandItems));
        }

        //GET api/table2/{id}
        [HttpGet("{id}")]
        //получить определенный айди из таблицы
        public ActionResult<SecondTableDTO> GetCommandById2(int id)
        {
            var commandItem = _repository.GetCommandById2(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<SecondTableDTO>(commandItem));

            }
            return NotFound();
        }
    }
}
