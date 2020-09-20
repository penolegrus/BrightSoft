using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APIBrightSoft
{
  [Serializable]
    public class Command
    {
        //модель для чтения 1 таблицы из базы данных
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Code { get; set; }
        [Required]
        public double Money { get; set; }      
        
    }
  
   

}
