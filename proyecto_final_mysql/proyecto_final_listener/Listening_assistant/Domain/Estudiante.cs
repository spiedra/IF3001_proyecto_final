﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listening_assistant.Domain
{
    class Estudiante
    {
        public Estudiante(int id, string nombre, string apellidos, int edad, string promedio, string carnet,  string direccion, int isDeleted)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Edad = edad;
            this.Promedio = promedio;
            this.Carnet = carnet;
            this.Direccion = direccion;
            this.IsDeleted = isDeleted;
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int Edad { get; set; }
        public string Promedio { get; set; }
        public string Carnet { get; set; }
        public string Direccion { get; set; }
        public int IsDeleted { get; set; }
    }
}
