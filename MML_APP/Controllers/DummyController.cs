using MML_APP.Datos;
using MML_APP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MML_APP.Controllers
{
    public class DummyController : ApiController
    {
        private MMLEntities db = new MMLEntities();


        [HttpGet]
        public IEnumerable<RecaudacionPuestoModels> recaudacion_puesto()
        {
            var consultest = db.Database.SqlQuery<RecaudacionPuestoModels>(
                    @"SELECT
                         'MERCED CONDUCTIVA' AS CONCEPTO, 
                         'CON CONTRATO' AS CONTRATO,
                         CTE.PERIODO,
                         CTE.EMISION,
                         CTE.SERVICIO,
                         CTE.MORA,
                         CTE.FEC_CANCELACION,
                         CD.COD_PUESTO,
                         CD.COD_PASAJE,
                         CD.COD_LETRA,
                         CD.NUM_CONTRATO,
                         C.COD_NOMBRE ,C.COD_TIPOPRO,'whats this?' as INSOLUTO
                         FROM 
                         SISAC.CONDUCTOR_PUESTO CD, SISAC.CONDUCTOR C, SISAC.MERCADO M, SISAC.CTACTE CTE , SISAC.PUESTO P, SISAC.GIRO G, SISAC.ACTIVIDAD A
                            WHERE 
                            CD.COD_PUESTO = CTE.COD_PUESTO
                            AND CD.COD_PASAJE = CTE.COD_PASAJE 
                            AND CD.COD_LETRA = CTE.COD_LETRA
                            AND CD.COD_MERCADO = CTE.COD_MERCADO         
                                AND P.cod_puesto=CD.cod_puesto 
                                AND P.cod_letra=CD.cod_letra 
                                AND P.cod_mercado=CD.cod_mercado 
                                AND P.cod_pasaje =CD.cod_pasaje
                                    and P.cod_giro=G.cod_giro
                                    and P.cod_activi=A.cod_activi 
                                    and P.cod_giro=A.cod_giro
                            AND CD.DOC_IDENTIDAD = C.DOC_IDENTIDAD
                            AND M.COD_MERCADO = CD.COD_MERCADO
                            AND CD.ESTADO='1' AND CD.NUM_CONTRATO IS NOT NULL
                            AND CTE.C_ID = 'P'
                            AND CD.COD_MERCADO IN ('080','101','107','114')
                            AND CTE.FEC_CANCELACION BETWEEN TO_DATE('01/12/2016','DD/MM/YYYY') AND add_months(TO_DATE('31/12/2017','DD/MM/YYYY'),-1) 
                            AND CD.COD_PASAJE IN ('CH')
                            AND CD.COD_PUESTO IN ('CH006')
                            AND CD.COD_LETRA IN (' ')
                        ORDER BY M.DES_MERCADO, CD.COD_PUESTO, CD.COD_PASAJE, CD.COD_LETRA, CTE.CANO, CTE.PERIODO DESC").ToList();
            return consultest;
        }

        class puesto
        {
            public RecaudacionPuestoModels re { get; set; }
        }



    }
}
