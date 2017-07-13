using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rahbaran_Andishe.Models
{
    public class OtherfieldsCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OtherfieldsCategory()
        {
            this.Forms = new HashSet<Form>();
        }

        public int Id { get; set; }
        public string Title { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Form> Forms { get; set; }
    }
}