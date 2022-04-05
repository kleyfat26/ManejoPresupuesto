using ManejoPresupuesto.Validaciones;
using System.ComponentModel.DataAnnotations;

namespace ManejoPresupuesto.Models
{
    public class TipoCuenta 
    {

        public int ID { get; set; }
        [Required(ErrorMessage = "el campo de nombre es requerido")]
        [PrimeraLetraMayuscula]

        public string Nombre { get; set; }

        public int UsuarioID { get; set; }
        public int Orden { get; set; }

        //public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        //{
        //    if (Nombre!=null&&Nombre.Length>0)
        //    {
        //        var primeraLetra = Nombre[0].ToString();
        //        yield return new ValidationResult("La primera letra debe ser mayuscula",
        //            new[] { nameof(Nombre) });


        //    }
    }
}

