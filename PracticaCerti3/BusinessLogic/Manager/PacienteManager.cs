using BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Manager
{
    public class PacienteManager
    {
        public string CrearCodePaciente(Paciente paciente)
        {
            return $"{paciente.Nombre[0]}{paciente.Apellido[0]}{paciente.CI}";
        }
    }
}
