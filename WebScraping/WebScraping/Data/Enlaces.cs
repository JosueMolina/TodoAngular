//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebScraping.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Enlaces
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Link { get; set; }
        public int NumeroPuntuaciones { get; set; }
        public decimal Puntuacion { get; set; }
        public int IdCategoria { get; set; }
    
        public virtual Categorias Categorias { get; set; }
    }
}