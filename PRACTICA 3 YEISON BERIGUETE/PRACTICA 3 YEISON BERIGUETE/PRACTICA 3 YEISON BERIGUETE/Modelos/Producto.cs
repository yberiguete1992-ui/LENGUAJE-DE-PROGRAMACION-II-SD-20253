using System;

namespace PRACTICA_3_YEISON_BERIGUETE.Modelos
{
    public class Producto
    {
        public int ProductoID { get; set; }
        public string NombreProducto { get; set; } 
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; } 

   
        public int CategoriaID { get; set; }
        public int ProveedorID { get; set; }

        
        public string NombreCategoria { get; set; }
        public string NombreProveedor { get; set; }
    }
}