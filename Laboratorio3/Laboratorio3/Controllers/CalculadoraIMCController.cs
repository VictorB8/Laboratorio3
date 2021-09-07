
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Laboratorio3.Models;


namespace Laboratorio3.Controllers
{
    public class CalculadoraIMCController : Controller
    {
        public ActionResult ResultadoAleatorioIMC()
        {
            PersonaModel[] lista = new PersonaModel[30];
            double[] ListaIMC = new double[30];
            Random random = new Random();
            for (int f = 0; f < 30; f++)
            {
                double altura = GetRandomNumber(random,1.0, 2.0);
                double peso = GetRandomNumber(random, 20.0, 150.0);
                PersonaModel persona = new PersonaModel(f, "Sin nombre", peso, altura);
                lista[f] = persona;
                double IMC = persona.Peso / (persona.Estatura * persona.Estatura);
                ListaIMC[f] = IMC;
                //ViewBag.IMC = IMC;
               // ViewBag.persona = persona;
            }
            ViewBag.lista = lista;
            ViewBag.listaIMC = ListaIMC;
            return View();
        }

        public ActionResult ResultadoAleatorioPreubaIMC()
        {
            PersonaModel persona = new PersonaModel(1, "Cristiano Ronaldo", 84.0, 1.87);
            double IMC = persona.Peso / (persona.Estatura * persona.Estatura);
            ViewBag.IMC = IMC;
            ViewBag.persona = persona;
            return View();
        }

        public double GetRandomNumber(Random random,double minimum, double maximum)
        {
            
            return random.NextDouble() * (maximum - minimum) + minimum;
        }
    }
}