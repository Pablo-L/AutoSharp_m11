﻿using System;

namespace library
{
   
    /// <summary>
    /// 
    /// </summary>
    public class ENConsulta
    {
        /// <summary>
        /// 
        /// </summary>
        private DateTime fecha;

        /// <summary>
        /// 
        /// </summary>
        private int id;

        /// <summary>
        /// 
        /// </summary>
        private string pregunta;

        /// <summary>
        /// 
        /// </summary>
        private string respuesta;


        /// <summary>
        /// propiedad publica cif
        /// </summary>
        private int CIFEmpresa { get => cif; set => cif = value; }

        /// <summary>
        /// propiedad publica dni
        /// </summary>
        private int DNIParticular { get => dni; set => dni = value; }


        /// <summary>
        /// constructor por defecto
        /// </summary>
        public Consulta()
        {
            fecha = DateTime.Now;
            id = 0;
            pregunta = null,
            respuesta = null;
        }

        /// <summary>
        /// constructor por valores
        /// </summary>
        /// <param name="fecha_"> parametro datetime fecha </param>
        /// <param name="id_"> parametro int id </param>
        /// <param name="pregunta_"> parametro string pregunta </param>
        /// <param name="respuesta"> parametro string respuesta </param>
        public Consulta(DateTime fecha_, int id_, string pregunta_, string respuesta)
        {
            fecha = fecha_;
            id = id_;
            pregunta = pregunta_;
            respuesta = respuesta_;
        }

        /// <summary>
        /// crear una consulta en la bbdd
        /// </summary>
        public bool createConsulta()
        {
            CADConsulta en = new CADConsulta();
            return en.createConsulta(this);
        }

        /// <summary>
        /// lee una consulta en la bbdd
        /// </summary>
        public bool readConsulta()
        {
            CADConsulta en = new CADConsulta();
            return en.readConsulta(this);
        }

        /// <summary>
        /// actualiza una consulta en la bbdd
        /// </summary>
        public bool updateConsulta()
        {
            CADConsulta en = new CADConsulta();
            return en.updateConsulta(this);
        }

        /// <summary>
        /// borra una consulta en la bbdd
        /// </summary>
        public bool deleteConsulta()
        {
            CADConsulta en = new CADConsulta();
            return en.deleteConsulta(this);
        }
    }
}