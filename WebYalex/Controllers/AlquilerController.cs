﻿using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebYalex.App_Start;
using WebYalex.Models;

namespace WebYalex.Controllers
{
    [Autenticado]
    public class AlquilerController : Controller
    {
        // GET: Alquiler
        public ActionResult Index()
        {
            using (DbModels context = new DbModels())
            {
                return View(context.alquileres.ToList());
            }
        }

        // GET: Alquiler/Details/5
        public ActionResult Details(int id)
        {
            using (DbModels context = new DbModels())
            {
                return View(context.alquileres.Where(x => x.id_alquiler == id).FirstOrDefault());
            }
        }

        // GET: Alquiler/Create
        public ActionResult Create()
        {
            using (DbModels context = new DbModels())
            {
                List<clientes> listaClientes = context.clientes.ToList();
                ViewBag.listaClientes = new SelectList(listaClientes, "id_cliente", "nombres");


                List<vehiculo> listaVehiculos = context.vehiculo.ToList();
                ViewBag.listaVehiculos = new SelectList(listaVehiculos, "id_vehiculo", "placa");
          
            }


            return View();
        }

        // POST: Alquiler/Create
        [HttpPost]
        public ActionResult Create(alquileres alquileres)
        {
            try
            {
                // TODO: Add insert logic here
                using (DbModels context = new DbModels())
                {
                    context.alquileres.Add(alquileres);
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Alquiler/Edit/5
        public ActionResult Edit(int id)
        {
            using (DbModels context = new DbModels())
            {
                alquileres alquiler = context.alquileres.Find(id);

                /*para traer el nombre del */
                List<clientes> listaClientes = context.clientes.ToList();
                int idClienteActual = alquiler.id_cliente;
                ViewBag.listaClientes = new SelectList(listaClientes, "id_cliente", "nombres", idClienteActual);

                

                List<vehiculo> listaVehiculos = context.vehiculo.ToList();
                int idVehiculoActual = alquiler.id_vehiculo;
                ViewBag.listaVehiculos = new SelectList(listaVehiculos, "id_vehiculo", "placa", idVehiculoActual);

                return View(alquiler);
            }
        }

        // POST: Alquiler/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, alquileres alquileres)
        {
            try
            {
                // TODO: Add update logic here
                using (DbModels context = new DbModels())
                {
                    context.Entry(alquileres).State = EntityState.Modified;
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Alquiler/Delete/5
        public ActionResult Delete(int id)
        {
            using (DbModels context = new DbModels())
            {
                return View(context.alquileres.Where(x => x.id_alquiler == id).FirstOrDefault());
            }
        }

        // POST: Alquiler/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                using (DbModels context = new DbModels())
                {
                    alquileres alquiler = context.alquileres.Where(x => x.id_alquiler == id).FirstOrDefault();
                    context.alquileres.Remove(alquiler);
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //public ActionResult RptAlquiler()
        //{
        //    return View();
        //}

        //public ActionResult DescargarReporteAlquiler()
        //{
        //    try
        //    {
        //        var rpt = new ReportClass();
        //        rpt.FileName = Server.MapPath("/Reportes/ReporteAlquiler.rpt");
        //        rpt.Load();

        //        //Report connection
        //        //rpt.SetParameterValue("DptoId", codigo);
        //        //rptH.SetParameterValue("ParamAlgo", algo);

        //        // Report connection
        //        var connInfo = CrystalReportsCnn.GetConnectionInfo();
        //        TableLogOnInfo logonInfo = new TableLogOnInfo();
        //        Tables tables;
        //        tables = rpt.Database.Tables;
        //        foreach (Table table in tables)
        //        {
        //            logonInfo = table.LogOnInfo;
        //            logonInfo.ConnectionInfo = connInfo;
        //            table.ApplyLogOnInfo(logonInfo);
        //        }

        //        Response.Buffer = false;
        //        Response.ClearContent();
        //        Response.ClearHeaders();

        //        //En PDF
        //        Stream stream = rpt.ExportToStream(ExportFormatType.PortableDocFormat);
        //        rpt.Dispose();
        //        rpt.Close();
        //        return new FileStreamResult(stream, "application/pdf");

        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}
    }
}
