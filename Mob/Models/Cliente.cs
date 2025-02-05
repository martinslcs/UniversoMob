using System.ComponentModel.DataAnnotations;

namespace Mob.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required]
        public string? Nome { get; set; }

        [Required]
        public string? CNPJ { get; set; }

        public bool DispenserMachine { get; set; }
        public bool PossuiIntegracao { get; set; }

        [Required]
        public DateTime InicioContrato { get; set; }

        public int Renovacoes { get; set; }
        public int UsuariosAtivos { get; set; }

        [Required]
        public string? TipoPagamento { get; set; }
    }
}
