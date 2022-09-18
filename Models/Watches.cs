using System.ComponentModel.DataAnnotations;

namespace MVCWatches.Models
{
    public class Watches
    {
        [Key]
        public int IDWatch { get; set; }
        public string? Categoria { get; set; }
        public string? Nome { get; set; }
        public string? Marca { get; set; }
        public string? Valor { get; set; }
        public string? Cor { get; set; }
        public string? Ano { get; set; }
    }
}
