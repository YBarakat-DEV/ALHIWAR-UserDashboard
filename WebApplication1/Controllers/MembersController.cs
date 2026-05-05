using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class MembersController : Controller
    {
        private readonly AppDB _context;

        public MembersController(AppDB context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var members = await _context.Members.ToListAsync();
            return View(members);
        }

        public IActionResult Seed()
        {
            var member = new Member
            {
                Code = "A1023",
                FirstName = "Mohammad",
                FatherName = "Ali",
                LastName = "Hamdan",
                MotherName = "Fatima",
                SpouseName = "Sara",
                Gender = "Male",
                BirthDate = new DateTime(1990, 3, 15),
                BirthPlace = "Beirut",
                PhoneNumber = "03012345",
                EmailAddress = "m.hamdan@email.com",
                Town = "Ghobeiry",
                Street = "Imam Ali Street",
                Sector = "Sector 3",
                Building = "Al Nour Building",
                Floor = "2",
                RegistryNumber = 987,
                RegistrySect = "sonna",
                MaritalStatus = "Married",
                FamilyGovernorate = "Beirut",
                FamilyDistrict = "Baabda",
                FamilyTown = "Ghobeiry",
                FamilyArea = "حي الجامع",
                FamilyCode = "HMD45",
                FamilyCount = 4,
                FormNumber = 54872,
                PoliticalRating = "Neutral",
                ElectionHelpWilling = true,
                ExperienceType = "Administration",
                Category = "Activist",
                PollingCenter = "Ghobeiry Public School",
                BallotBox = 12,
                Nearby = "Near",
                VoterStatus = "Eligible",
                VolunteerRole = "Coordinator",
                PosterWilling = true,
                NationalID = "123456789",
                IDCardStatus = "Valid",
                IDCardNotes = "ID card is valid",
                EducationLevel = "Bachelor Degree",
                InstitutionName = "Lebanese University",
                CertificateType = "Business Administration",
                EmploymentStatus = "Employed",
                CompanyName = "Al Ofok Company",
                Rating = "A",
                RequestStatus = "Approved",
                MembershipStatus = "Active",
                IsVolunteer = true,
                IsActive = true,
                Description = "Active member and campaign supporter",
                Remarks = "Very cooperative",
                DataSource = "Manual Entry",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now
            };

            _context.Members.Add(member);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}