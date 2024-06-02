﻿using System.ComponentModel.DataAnnotations;

namespace BbCenter.Dto.Auth
{
    public class RegisterDto
    {
        [Required(ErrorMessage = "The email can not empty!")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string DateOfBirth { get; set; }

        [Required(ErrorMessage = "The phone can not empty!")]
        [RegularExpression(@"^(\d+)?$", ErrorMessage = "The phone must be a number!")]
        [MinLength(10, ErrorMessage = "The phone must be 10 number!")]
        [MaxLength(10, ErrorMessage = "The phone must be 10 numbber!")]
        public string PhoneNumber { get; set; }
        public string? Address { get; set; }
        public string? Degree { get; set; }
        public Guid RoleId { get; set; }

        public Guid? SubjectId { get; set; }
        public Guid? CenterId { get; set; }

    }
}
