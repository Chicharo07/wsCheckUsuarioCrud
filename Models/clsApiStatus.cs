using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wsCheckUsuario.Models
{
	public class clsApiStatus
	{
		// Estado de la ejecucion del enpoint (metodo)
		public bool statusExec { get; set; }
		// Descripcion del resultado
		public string msg { get; set; }
		//Codigo de ejecucion del endpoint (metodo)
		public int ban { get; set; }
		//Objeto json para envio de datos
		public JObject datos { get; set; }
	}
}