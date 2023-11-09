using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototipoProjetoInterdisciplinar.Model
{
    public class VagaModel
    {

        public List<bool> DisponibilidadeVagas { get; set; }
        public List<string> Buttons { get; set; }   

        public VagaModel()
        {
            DisponibilidadeVagas = new List<bool>();
            Buttons = new List<string>();   
        }

    }
}
