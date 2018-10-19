﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleccionFutbol
{
    class Seleccion
    {
        private int id;
        private string nombre;
        private string apellido;
        private int edad;
        private bool viajar;
        private bool conc;


        public Seleccion()
        {
            Contador(cont);
        }

        public int GetId()
        {
            return id;
        }
        public string GetNombre()
        {
            return nombre;
        }
        public string GetApellido()
        {
            return apellido;
        }
        public int GetEdad()
        {
            return edad;
        }
        public bool GetViajar()
        {
            return viajar;
        }
        public string GetConcentrarse(bool conc)
        {
           
                return "Concentrado";
         
        }

        public void SetId(int id)
        {
            this.id = id;
        }
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public void SetApellido(string apellido)
        {
            this.apellido = apellido;
        }
        public void SetEdad(int edad)
        {
            this.edad = edad;
        }
        public void SetViajar(bool viajar)
        {
            this.viajar = viajar;
        }
        public void SetConcentrarse(bool conc)
        {
            this.conc = conc;
        }

        //public string Concentrarse(bool conc)
        //{
        //    return "Está concentrado";
        //}

        //public string Viajar (bool viajar)
        //{
            
        //    return "Ha viajado";
        //}

        int cont = 0;
        public static int Contador(int cont)
        {
            cont++;
            return cont;

        }

        public string ToStringSeleccion()
        {
            return "\nId: " + id + "\nNombre: " + nombre + "\nApellido: " + apellido + "\nEdad: " + edad + "\n¿Ha viajado?" + viajar + "\n¿Está concentrado? " + conc;
        }
    }

}