//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MOBILEVECTOR
{
    using System;
    using System.Collections.Generic;
    
    public partial class part
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public part()
        {
            this.cheque = new HashSet<cheque>();
        }
    
        public int id_part { get; set; }
        public string part_name { get; set; }
        public string manufacturer { get; set; }
        public int price { get; set; }
        public string warranty { get; set; }
        public int id_client { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cheque> cheque { get; set; }
    }
}
