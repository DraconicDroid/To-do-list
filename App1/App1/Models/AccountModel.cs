using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.SignalR.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using Microsoft.AspNetCore.CookiePolicy;

namespace App1.Models
{
    public class Login
    {
        [Key] public int SysUserId { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Username")]
        public string LoginName { get; set; }

        [Required(ErrorMessage = "*")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
        
        [Display(Name = "Remember me")]
        public bool RememberMe { get; set; }
    
    }

    public class Register
    {
        [Key] public int SYSUserID { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Username")]
        public string RegisterName { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class SubmitBtn_Click
    {
        SqlConnection con = new SqlConnection("Data Source=Server");
        
        //con.Open();

        //open connection, check db and proceed.
        //https://docs.microsoft.com/en-us/aspnet/core/security/data-protection/consumer-apis/password-hashing?view=aspnetcore-6.0 - hashing password so not stored in text
        //reg ex validation (valid email, strong password, valid username)
        //https://qawithexperts.com/article/asp-net/how-to-create-login-registration-page-in-mvc-with-database-a/170
    }
}