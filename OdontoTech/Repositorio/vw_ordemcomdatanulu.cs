//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Repositorio
{
    using System;
    using System.Collections.Generic;
    
    public partial class vw_ordemcomdatanulu
    {
        public int ord_codigo { get; set; }
        public Nullable<System.DateTime> ord_dataderecebimento { get; set; }
        public Nullable<System.DateTime> ord_dataentrega { get; set; }
        public Nullable<int> ord_quantidade { get; set; }
        public string ord_descricao { get; set; }
        public Nullable<decimal> ord_valor { get; set; }
        public int cod_clientes { get; set; }
        public string pec_nome { get; set; }
        public string cli_nome { get; set; }
    }
}
