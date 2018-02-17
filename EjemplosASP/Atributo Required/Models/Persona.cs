using Atributo_Required.Models.Validaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Atributo_Required.Models
{
    public class Persona: IValidatableObject
    {
        public int Id { get; set; }

        //Atributo StringLength: Longitud minima y maxima del campo "Nombre"
        [StringLength(50,MinimumLength = 5,ErrorMessage ="El campo {0} debe tener minimo {2} caracteres y maximo {1}" +
            " caracteres")]
        public string Nombre { get; set; }

        //Atributo Required: El atributo "Apellido" es obligatorio para crear un nuevo modelo de "Persona" en la BD
        [Required(ErrorMessage ="El campo {0} es obligatorio para crear")]
        public string Apellido { get; set; }

        //Atributo Range: El atributo "Edad" es obligatorio y debe estar entre el rango de 18 y el maximo valor
        //que soporta el tipo de dato double
        [Range(18,double.MaxValue,ErrorMessage ="El campo {0} debe ser un numero entre {1} y {2}")]
        public double Edad { get; set; }

        [StringLength(200)]
        public string Email { get; set; }

        //Este atributo no se crea en la base de datos y se compara con el atributo Email
        [NotMapped]
        [System.ComponentModel.DataAnnotations.Compare("Email")]
        public string ConfirmarEmail { get; set; }

        //Valida que haya un numero de tarjeta de credito valido en el campo
        [CreditCard]
        public string TarjetaCredito { get; set; }

        //A traves de Jquery validation hace la validacion en el lado del cliente, se genera un metodo
        //en el controlador llamado NumeroPar y recibe como parametro un atributo llamado "NumeroPar" al igual
        //que este campo
        [Remote("NumeroPar", "Personas",ErrorMessage ="El número ingresado no es par")]
        public int NumeroPar { get; set; }

        //La definicion del atributo personalizado se encuentra en la carpeta model/Validaciones
        [DivisibleEntre(3)]
        public int NumeroDivisor { get; set; }

        #region IValidatableObject

        //campos de la validacion compleja
        public decimal Salario { get; set; }

        //Atributo Display: El atributo LabelFor busca si esta implementado el atributo display,
        //si lo esta y esta definido el parametro nombre, lo muestra con esa propiedad, si no, coloca
        //el nombre del atributo del modelo
        [Display(Name ="Monto del Préstamo")]
        public decimal MontoPrestamo { get; set; }

        //Para hacer la validacion compleja se implementa la interfaz "IValidatableObject"
        //y se implementa el metodo a continuacion:
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var errores = new List<ValidationResult>();

            if(Salario * 4 < MontoPrestamo)
            {
                errores.Add(new ValidationResult("El monto del prestamo debe ser 4 veces igual o menor al salario",
                    new String[] { "MontoPrestamo" }));
            }

            return errores;
        }
        #endregion IValidatableObject
    }
}