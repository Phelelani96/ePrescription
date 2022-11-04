using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ePrescription.Data;
using Microsoft.AspNetCore.Identity;

namespace ePrescription.Areas.Identity.Data;

// Add profile data for application users by adding properties to the User class
public class User : IdentityUser
{
    public User()
    {

    }
    public User(string firstName, string lastName, string discriminator,string email,string phoneNumber, int? practiceId, int? qualificationId, string? registrationNo)
    {
        FirstName = firstName;
        LastName = lastName;
        Discriminator = discriminator;
        Email = email;
        PhoneNumber = phoneNumber;
        PracticeId = practiceId;
        QualificationId = qualificationId;
        RegistrationNo = registrationNo;
    }

    [Required]
    [Display(Name = "First Name")]
    public string FirstName { get; set; } = string.Empty;

    [Required]
    [Display(Name = "Last Name")]
    public string LastName { get; set; } = string.Empty;

    public string FullName
    {
        get
        {
            return FirstName + " " + LastName;
        }
    }

    //[Required]
    [Display(Name = "ID Number")]
    [MaxLength(13)]
    public string? IDNumber { get; set; } = string.Empty;

    public string? DOB
    {
        get
        {
            if (IDNumber == null || IDNumber == "")
            {
                return null;
            }
            else
            {
                return IDNumber.Substring(0, 6);
            }
            
                
        }
    }

    [Required]
    public string Discriminator { get; set; } = string.Empty;

    [Required]
    [Display(Name = "Address Line 1")]
    public string AddressLine1 { get; set; } = string.Empty;

    [Display(Name = "Address Line 2")]
    public string? AddressLine2 { get; set; }

    //[Required]
    public int? SuburbID { get; set; }

    [Required]
    public string Status { get; set; }

    public Suburb? Suburb { get; set; }

    //Pharmacist Properties//
    public int? PharmacyId { get; set; }

    //Doctor Properties//

    [Display(Name = "Practice")]
    public int? PracticeId { get; set; }

    [Display(Name = "Highest Qualification")]
    public int? QualificationId { get; set; }

    [Display(Name = "Health Council Registration Number")]
    public string? RegistrationNo { get; set; }

    ///////////>>>>Navigation Properties<<<<<///////

    //Doctor//
    public Practice? Practice { get; set; }
    public Qualification? Qualification { get; set; }

    //Pharmacist//
    public Pharmacy? Pharmacy { get; set; }

    //Patient//
    public Medical_History? Medical_History { get; set; }
    public ICollection<Patient_Allergy>? Allergies { get; set; }


}

