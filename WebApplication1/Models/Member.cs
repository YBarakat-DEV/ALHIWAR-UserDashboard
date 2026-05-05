using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Member
    {
        [Key]
        public int MemberId { get; set; }
        public string? Code { get; set; }
        public string? FirstName { get; set; }
        public string? FatherName { get; set; }
        public string? LastName { get; set; }
        public string? MotherName { get; set; }
        public string? SpouseName { get; set; }
        public string? Gender { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? BirthPlace { get; set; }
        public string? PhoneNumber { get; set; }
        public string? EmailAddress { get; set; }
        public string? Town { get; set; }
        public string? Street { get; set; }
        public string? Sector { get; set; }
        public string? Building { get; set; }
        public string? Floor { get; set; }
        public int? RegistryNumber { get; set; }
        public string? RegistrySect { get; set; }
        public string? MaritalStatus { get; set; }
        public string? FamilyGovernorate { get; set; }
        public string? FamilyDistrict { get; set; }
        public string? FamilyTown { get; set; }
        public string? FamilyArea { get; set; }
        public string? FamilyCode { get; set; }
        public int? FamilyCount { get; set; }
        public int? FormNumber { get; set; }
        public string? PoliticalRating { get; set; }
        public bool ElectionHelpWilling { get; set; }
        public string? ExperienceType { get; set; }
        public string? Category { get; set; }
        public string? PollingCenter { get; set; }
        public int? BallotBox { get; set; }
        public string? Nearby { get; set; }
        public string? VoterStatus { get; set; }
        public string? VolunteerRole { get; set; }
        public bool PosterWilling { get; set; }
        public string? NationalID { get; set; }
        public string? IDCardStatus { get; set; }
        public string? IDCardNotes { get; set; }
        public string? EducationLevel { get; set; }
        public string? InstitutionName { get; set; }
        public string? CertificateType { get; set; }
        public string? EmploymentStatus { get; set; }
        public string? CompanyName { get; set; }
        public string? Rating { get; set; }
        public string? RequestStatus { get; set; }
        public string? MembershipStatus { get; set; }
        public bool IsVolunteer { get; set; }
        public bool IsActive { get; set; }
        public string? Description { get; set; }
        public string? Remarks { get; set; }
        public string? DataSource { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}