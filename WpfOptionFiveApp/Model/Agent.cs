//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfOptionFiveApp.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Agent
    {
        public int ID { get; set; }
        public string CompanyName { get; set; }
        public int IDAgentType { get; set; }
        public string Address { get; set; }
        public int INN { get; set; }
        public int KPP { get; set; }
        public int IDDirectorName { get; set; }
        public string Phone { get; set; }
        public string Logotype { get; set; }
        public int IDPriority { get; set; }
        public int IDPointOfSales { get; set; }
        public string IDRole { get; set; }
    
        public virtual AgentType AgentType { get; set; }
        public virtual DirectorName DirectorName { get; set; }
        public virtual PointOfSales PointOfSales { get; set; }
        public virtual Priority Priority { get; set; }
        public virtual Role Role { get; set; }
    }
}
