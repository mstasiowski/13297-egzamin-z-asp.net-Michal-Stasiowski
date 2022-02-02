using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;

namespace _13297_zaliczenie_wyklad.Models
{
    public class Mark
    {
        [HiddenInput]
        public int Id { get; set; }

        [Required(ErrorMessage ="Podaj numer albumu")]
        [Range(minimum: 0, maximum: 9999, ErrorMessage = "numer indeksu musi mieścić się w przedziale 0-9999")]
        public decimal album { get; set; }

        [Required(ErrorMessage ="Podaj ilość punktów")]
        [Range(minimum: 0, maximum: 100, ErrorMessage = "Liczba punktów musi mieścić się w przedziale 0-100")]
        public decimal points { get; set; }

        [DataType(DataType.Date)]
        public DateTime todaytime { get; set; }

    }
}
