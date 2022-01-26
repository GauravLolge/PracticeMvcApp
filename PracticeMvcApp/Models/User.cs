namespace PracticeMvcApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Web;

    public class User
    {
        [Required(ErrorMessage = "Name can not be blank")]
        public string Name { get; set; }
    }
}