using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using MML_APP.Datos;
using MML_APP.Models;
using System.Data.SqlClient;

namespace MML_APP.Controllers
{
    public class DETCOBsController : ApiController
    {
        private MMLEntities db = new MMLEntities();

        // GET: api/DETCOBs
        public IQueryable<DETCOB> GetDETCOB()
        {
            return db.DETCOB;
            //return db.Database.SqlQuery<TupaContext>(@"select * from cat").ToArray();
        }

        // GET: api/DETCOBs/5
        [ResponseType(typeof(DETCOB))]
        public async Task<IHttpActionResult> GetDETCOB(string id)
        {
            DETCOB dETCOB = await db.DETCOB.FindAsync(id);
            if (dETCOB == null)
            {
                return NotFound();
            }

            return Ok(dETCOB);
        }


        
        [HttpGet]
        public IEnumerable<TupaModels> GetPrueba1()
        {
            //var consult= db.Database.SqlQuery<Consulta>(@"SELECT TOTDET AS ALGO,PRECUNI FROM DETCOB WHERE NUMDOC="+id).ToList();
            var consult = db.Database.SqlQuery<TupaModels>(@"SELECT M.DES_MERCADO,
            C.CLADOC, T.DESDOC,
            C.SERDOC, C.PTOCOB,
	        D.CODING , SISAC.m_f_Servicio(D.CODING) AS DESC_INGRESO,
	        C.NUMDOC , RTRIM(C.NOMCONT) AS NOMCONT ,
	        C.FECHEMIS,	D.CODADIC AS PUESTO, D.PASAJE, D.LETRA,
	        TO_NUMBER(D.NUMORD) NUM_ORDEN, D.ANODEU, D.MESDEU , D.BASDET , D.MORDET , D.IGVDET,  D.TOTDET, C.CONTROL
        FROM   SISAFM.DETCOB D , SISAFM.CABECOB C , SISAC.MERCADO M,  SISAFM.TIPDOC T
        WHERE
	        ( C.PTOCOB = D.PTOCOB AND C.SERDOC = D.SERDOC AND C.CLADOC=D.CLADOC AND C.NUMDOC =  D.NUMDOC AND
	        C.ANODOC = D.ANODOC AND C.MESDOC = D.MESDOC ) AND
	        C.CLADOC=T.CLADOC AND
	        D.MERCADO =  M.COD_MERCADO(+)  AND C.ESTADO = '1' AND	
	        D.CODING IN ('2267','2446','2450','8664',
            '8665', '8667', '8831', '8833', '9039', '2267',
            '2450', '8664', '8665', '8667', '8831', '8833', '9039' ) 
	        AND C.FECHEMIS BETWEEN TO_DATE('01/12/2016','DD/MM/YYYY') AND TO_DATE('31/12/2016','DD/MM/YYYY')
        ORDER BY M.DES_MERCADO,D.CODING , C.NUMDOC ,  TO_NUMBER(D.NUMORD) ASC").ToList();
            return consult;
        }


    }
}