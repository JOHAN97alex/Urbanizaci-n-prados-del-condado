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

        public TBL_PROPIETARIO ToTBL_PROPIETARIO(PropietarioViewModel model, bool isNew)
        {
            return new TBL_PROPIETARIO
            {
                PRO_ID = isNew ? 0 : model.PRO_ID,
                PRO_LOTE = model.PRO_LOTE,
                PRO_TIPO = model.PRO_TIPO,
                PRO_NOMBRES = model.PRO_NOMBRES,
                PRO_APELLIDOS = model.PRO_APELLIDOS,
                PRO_OBSERVACIONES = model.PRO_OBSERVACIONES,
                PRO_TELEFONO = model.PRO_TELEFONO,
                PRO_EMAIL = model.PRO_EMAIL,
                PRO_TIPOIDENTIFICACION = model.PRO_TIPOIDENTIFICACION,
                PRO_IDENTIFICACION = model.PRO_IDENTIFICACION,
                PRO_NOMBREFAMILIAR = model.PRO_NOMBREFAMILIAR,
                PRO_APELLIDOFAMILIAR = model.PRO_APELLIDOFAMILIAR,
                PRO_TELEFONOFAMILIAR = model.PRO_TELEFONOFAMILIAR,
                PRO_NOMENCLATURA = model.PRO_NOMENCLATURA,
                PRO_FECHAINGRESOBASE = model.PRO_FECHAINGRESOBASE,
                PRO_FECHASALIDABASE = model.PRO_FECHASALIDABASE,
                PRO_INQUILINOS = model.PRO_INQUILINOS,
                //PRO_FECHACREACIONBASE = DateTime.Now,
                PRO_ESTADO = 'A',
                
            };
        }

        public PropietarioViewModel ToPropietarioViewModel(TBL_PROPIETARIO tbl_Propietario)
        {
            return new PropietarioViewModel
            {
                PRO_ID = tbl_Propietario.PRO_ID,
                PRO_LOTE = tbl_Propietario.PRO_LOTE,
                PRO_TIPO = tbl_Propietario.PRO_TIPO,
                PRO_NOMBRES = tbl_Propietario.PRO_NOMBRES,
                PRO_APELLIDOS = tbl_Propietario.PRO_APELLIDOS,
                PRO_OBSERVACIONES = tbl_Propietario.PRO_OBSERVACIONES,
                PRO_TELEFONO = tbl_Propietario.PRO_TELEFONO,
                PRO_EMAIL = tbl_Propietario.PRO_EMAIL,
                PRO_TIPOIDENTIFICACION = tbl_Propietario.PRO_TIPOIDENTIFICACION,
                PRO_IDENTIFICACION = tbl_Propietario.PRO_IDENTIFICACION,
                PRO_NOMBREFAMILIAR = tbl_Propietario.PRO_NOMBREFAMILIAR,
                PRO_APELLIDOFAMILIAR = tbl_Propietario.PRO_APELLIDOFAMILIAR,
                PRO_TELEFONOFAMILIAR = tbl_Propietario.PRO_TELEFONOFAMILIAR,
                PRO_NOMENCLATURA = tbl_Propietario.PRO_NOMENCLATURA,
                PRO_FECHAINGRESOBASE = tbl_Propietario.PRO_FECHAINGRESOBASE,
                PRO_FECHASALIDABASE = tbl_Propietario.PRO_FECHASALIDABASE,
                PRO_INQUILINOS = tbl_Propietario.PRO_INQUILINOS,
                // PRO_FECHACREACIONBASE = DateTime.Now,
                PRO_ESTADO = 'A'

            };
        }
    }
}
