using LabProject.Migrations;

namespace LabProject.Models;

public class ContactMapper
{
    public static ContactEntity ToEntity(ContactModel arg)
    {
        return new ContactEntity()
        {
            Id = arg.Id,
            BirthDate = arg.BirthDate,
            Email = arg.Email,
            FirstName = arg.FirstName,
            LastName = arg.LastName,
            PhoneNumber = arg.PhoneNumber,
            Category = arg.Category,
            Organization = arg.Organization,
            OrganizationId = arg.OrganizationId,
        };
        
        
    }

    public static ContactModel FromEntity(ContactEntity arg)
    {
        return new ContactModel()
        {
            Id = arg.Id,
            BirthDate = arg.BirthDate,
            Email = arg.Email,
            FirstName = arg.FirstName,
            LastName = arg.LastName,
            PhoneNumber = arg.PhoneNumber,
            Category = arg.Category,
            OrganizationId = arg.OrganizationId,
            Organization = arg.Organization
        };
    }
}