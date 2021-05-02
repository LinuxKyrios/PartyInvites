using System;
using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please input your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please input your email address")]
        [RegularExpression(".+\\@.+\\..",
            ErrorMessage = "Please input a correct email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "please input your phone number.")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please choose if you will take part in our party")]
        public bool? WillAttend { get; set; }
    }
    /*This model is for get personal data from invited users*/
}
