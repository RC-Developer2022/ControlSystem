using ControlSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ControlSystem.Infrastructure.Settings;

public sealed class PersonSettings : IEntityTypeConfiguration<Person>
{
    public void Configure(EntityTypeBuilder<Person> builder)
    {
        builder.ToTable("People");
        builder.HasKey(x => x.Id).HasName("PersonId");
        builder.Property(x => x.Id).HasColumnName("PersonId");
        builder.Property(x => x.Name).HasMaxLength(150).HasColumnName("NamePerson");
        builder.Property(x => x.Age).HasColumnName("Age");
        builder.Property(x => x.BirthDay).HasColumnName("BirthDay");
        builder.Property(x => x.Identity).HasMaxLength(9).HasColumnName("IdentityPerson");
        builder.Property(x => x.IndividualRegistration).HasMaxLength(11).HasColumnName("IndividualRegistration");
        builder.Property(x => x.Working).HasColumnName("Working");
    }
}
