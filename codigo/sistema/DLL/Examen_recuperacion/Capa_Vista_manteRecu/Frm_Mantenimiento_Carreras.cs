using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_manteRecu
{
    public partial class Frm_Mantenimiento_Carreras : Form
    {
        public Frm_Mantenimiento_Carreras()
        {
            InitializeComponent();
            // Parametros para navegador
            Capa_Controlador_Navegador.Cls_ConfiguracionDataGridView config =
                new Capa_Controlador_Navegador.Cls_ConfiguracionDataGridView
                {
                    Ancho = 1100,
                    Alto = 200,
                    PosX = 10,
                    PosY = 300,
                    ColorFondo = Color.AliceBlue,
                    TipoScrollBars = ScrollBars.Both,
                    Nombre = "dgv_Carreras"
                };

            string[] columnas = {
                "carreras",
                "codigo_carrera",
                "nombre_carrera",
                "codigo_facultad",
                "estatus_carrera"
            };

            string[] sEtiquetas = {
                "Código Carrera",
                "Nombre Carrera",
                "Codigo Facultad",
                "Estatus Carrera"
            };

            int id_aplicacion = 615;
            int id_modulo = 5;

            navegador1.IPkId_Aplicacion = id_aplicacion;
            navegador1.IPkId_Modulo = id_modulo;
            navegador1.configurarDataGridView(config);
            navegador1.SNombreTabla = columnas[0];
            navegador1.SAlias = columnas;
            navegador1.SEtiquetas = sEtiquetas;
            navegador1.mostrarDatos();
        }
    }
}
