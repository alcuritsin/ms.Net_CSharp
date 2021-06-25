using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    class Department_TR:ADepartment, IReception, ITreatment
    {

        public void ReceptionOfPatients()
        {
            // Приём больных
        }

        public void TreatmentOfPatients()
        {
            // Лечение больных

        }
    }
}
