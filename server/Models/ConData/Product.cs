using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomMethodBenjamin.Models.ConData
{
  [Table("Products", Schema = "dbo")]
  public partial class Product
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Int64 ProductID
    {
      get;
      set;
    }
    [ConcurrencyCheck]
    public string ProductName
    {
      get;
      set;
    }
    [ConcurrencyCheck]
    public Int64? CategoryID
    {
      get;
      set;
    }
    public ProductCategory ProductCategory { get; set; }
    [ConcurrencyCheck]
    public decimal? UnitPrice
    {
      get;
      set;
    }
    [ConcurrencyCheck]
    public string Picture
    {
      get;
      set;
    }
  }
}
