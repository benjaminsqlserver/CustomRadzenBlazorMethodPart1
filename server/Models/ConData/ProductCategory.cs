using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomMethodBenjamin.Models.ConData
{
  [Table("ProductCategories", Schema = "dbo")]
  public partial class ProductCategory
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Int64 CategoryID
    {
      get;
      set;
    }

    public ICollection<Product> Products { get; set; }
    [ConcurrencyCheck]
    public string CategoryName
    {
      get;
      set;
    }
  }
}
