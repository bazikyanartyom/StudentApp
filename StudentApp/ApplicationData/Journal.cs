//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentApp.ApplicationData
{
    using System;
    using System.Collections.Generic;
    
    public partial class Journal
    {
        public int id { get; set; }
        public int idEmloyes { get; set; }
        public int idPosition { get; set; }
        public int idNameDeport { get; set; }
    
        public virtual Employes Employes { get; set; }
        public virtual NameDeport NameDeport { get; set; }
        public virtual Position Position { get; set; }
    }
}
