using Entidades;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clase3PracticaMVC.Controllers
{
    public class JugadoresController : Controller
    {
        public static List<Entidades.Jugador> Jugadores { get; set; }

        public JugadoresController()
        {
            if (Jugadores == null)
            {
                Jugadores = new List<Jugador>();
            }
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CrearUsandoRequest()
        {
            string nombre = Request.Form["Nombre"].ToString();
            string apellido = Request.Form["Apellido"].ToString();
            string club = Request.Form["Club"].ToString();
            return View();
        }

        [HttpGet]
        public IActionResult Crear(string nombre, string apellido, string club)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Crear(Jugador jug)
        {
            string nombre = jug.Nombre;
            string apellido = jug.Apellido;
            string club = jug.Club;
            return View();
        }

        public IActionResult VerDetalle()
        {
            Jugador j = new Jugador();
            j.Nombre = "Pablo";
            j.Apellido = "Aymar";
            j.Club = "Valencia";

            return View(j);
        }

        public IActionResult SinClub()
        {
            List<Jugador> jugSinClub = new List<Jugador>();
            Jugador j = new Jugador();
            j.Nombre = "Pablo";
            j.Apellido = "Aymar";

            jugSinClub.Add(j);
            jugSinClub.Add(j);
            jugSinClub.Add(j);

            return View(jugSinClub);
        }


        [HttpPost]
        public IActionResult Cargar(Jugador jug)
        {
            //TODO: agregar a la lista
            return View();
        }

        public IActionResult JugadoresCargados()
        {
           //TODO: retornar lista (deberian tambien crear la vista)
            return View();
        }
    }
}
