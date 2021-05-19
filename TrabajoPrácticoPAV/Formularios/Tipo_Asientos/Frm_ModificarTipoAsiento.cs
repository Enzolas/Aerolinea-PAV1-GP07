﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPrácticoPAV.Clase;
using TrabajoPrácticoPAV.Backend;
using TrabajoPrácticoPAV.NE_Usuarios;

namespace TrabajoPrácticoPAV.Formularios.Tipo_Asientos
{
    public partial class Frm_ModificarTipoAsiento : Form
    {
        public string Pp_nombre { get; set; }
        public object Pp_costo { get; set; }
        public string Id_Tipo { get; set; }
        Conexion_DB _BD = new Conexion_DB();
        NE_TipoAsiento TA = new NE_TipoAsiento();


        public Frm_ModificarTipoAsiento()
        {
            InitializeComponent();
        }

        private void Frm_ModificarTipoAsiento_Load(object sender, EventArgs e)
        {
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
            
            txt_idTipo.Text = Id_Tipo;
            txt_Nombre.Text = Pp_nombre;
            msktxt_Costo.Text = Pp_costo.ToString();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Actualizar_Click_1(object sender, EventArgs e)
        {
            TA.Modificar(this.Controls);
            this.Close();
        }
        
    }
}
