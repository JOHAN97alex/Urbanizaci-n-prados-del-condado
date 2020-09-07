using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Urbanizacion.Web.Data.Entities;
using Urbanizacion.Web.Models;

namespace Urbanizacion.Web.Helpers
{
    public class ConverterHelper : IConverterHelper
    {
        public TBL_VEHICULO ToTBL_VEHICULO(VehiculoViewModel model, bool isNew)
        {
            return new TBL_VEHICULO
            {
                VEH_ID = isNew ? 0 : model.VEH_ID,
                VEH_CODIGO = model.VEH_CODIGO,
                VEH_PLACA = model.VEH_PLACA,
                VEH_FECHACREACIONBASE = DateTime.Now,
                VEH_ESTADO = 'A'

            };
        }

        public VehiculoViewModel ToVehiculoViewModel(TBL_VEHICULO tbl_Vehiculo)
        {
            return new VehiculoViewModel
            {
                VEH_ID = tbl_Vehiculo.VEH_ID,
                VEH_CODIGO = tbl_Vehiculo.VEH_CODIGO,
                VEH_PLACA = tbl_Vehiculo.VEH_PLACA,
                VEH_FECHACREACIONBASE = DateTime.Now,
                VEH_ESTADO = 'A'

            };
        }
    }
}
