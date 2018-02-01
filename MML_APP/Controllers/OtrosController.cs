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
    
    public class OtrosController : ApiController
    {
        private MMLEntities db = new MMLEntities();


        [HttpGet]
        public IEnumerable<TupaModels> QueryTest()
        {
             var consultest = db.Database.SqlQuery<TupaModels>(
                                @"SELECT M.DES_MERCADO,
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
            return consultest;
        }


        [HttpGet]
        public IEnumerable<TupaModels> Tupa(string fi, string ff)
        {
            var consultupa = db.Database.SqlQuery<TupaModels>(
                                @"SELECT M.DES_MERCADO,
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
	                                D.CODING IN ('8664', '8665', '8667', '8831', '8833', '9039' ) 
	                                AND C.FECHEMIS BETWEEN TO_DATE('"+fi+"','DD/MM/YYYY') AND TO_DATE('"+ff+"','DD/MM/YYYY') ORDER BY M.DES_MERCADO,D.CODING , C.NUMDOC ,  TO_NUMBER(D.NUMORD) ASC").ToList();

            return consultupa;
        }

        [HttpGet]
        public IEnumerable<TupaModels> SSHH(string fi, string ff)
        {
            var consultasshh = db.Database.SqlQuery<TupaModels>(
                               @"SELECT M.DES_MERCADO,
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
	                                D.CODING IN ('2267') 
	                               AND C.FECHEMIS BETWEEN TO_DATE('" + fi + "','DD/MM/YYYY') AND TO_DATE('" + ff + "','DD/MM/YYYY') ORDER BY M.DES_MERCADO,D.CODING , C.NUMDOC ,  TO_NUMBER(D.NUMORD) ASC").ToList();
            return consultasshh;
        }

        [HttpGet]
        public IEnumerable<TupaModels> Parqueo(string fi, string ff)
        {
            var consultPark = db.Database.SqlQuery<TupaModels>(
                               @"SELECT M.DES_MERCADO,
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
	                                D.CODING IN ('2450') 
	                               AND C.FECHEMIS BETWEEN TO_DATE('" + fi + "','DD/MM/YYYY') AND TO_DATE('" + ff + "','DD/MM/YYYY') ORDER BY M.DES_MERCADO,D.CODING , C.NUMDOC ,  TO_NUMBER(D.NUMORD) ASC").ToList();
            return consultPark;
        }






    }
}
