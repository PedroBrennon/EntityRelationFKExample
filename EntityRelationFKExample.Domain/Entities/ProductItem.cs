using System.ComponentModel.DataAnnotations.Schema;

namespace EntityRelationFKExample.Domain.Entities
{
    public class ProductItem
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }
        
        public Product Product { get; set; }

    }
}
