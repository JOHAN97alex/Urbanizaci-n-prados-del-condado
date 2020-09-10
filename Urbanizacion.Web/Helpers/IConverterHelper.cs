using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Urbanizacion.Web.Data.Entities;
using Urbanizacion.Web.Models;

namespace Urbanizacion.Web.Helpers
{
    public interface IConverterHelper
    {
        //conversion en el video parte 9
        TBL_VEHICULO ToTBL_VEHICULO(VehiculoViewModel model, bool isNew);

        VehiculoViewModel ToVehiculoViewModel(TBL_VEHICULO tbl_Vehiculo);

        TBL_PROPIETARIO ToTBL_PROPIETARIO(PropietarioViewModel model, bool isNew);

        PropietarioViewModel ToPropietarioViewModel(TBL_PROPIETARIO tbl_Propietario);
    }
}
