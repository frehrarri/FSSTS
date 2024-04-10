using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using EntityFramework.EntityModels;
using System.Reflection.Emit;
using System.Reflection.Metadata;

namespace EntityFramework.EntityTypeConfigs
{
    public class AccountInfoTypeConfig : IEntityTypeConfiguration<AccountInfo>
    {
        public void Configure(EntityTypeBuilder<AccountInfo> builder)
        {
            builder.ToTable("AccountInfo");

            builder.Property(ai => ai.AccountInfoID)
                .ValueGeneratedOnAdd();

            builder.Property(ai => ai.Username)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsRequired(true);

            builder.Property(ai => ai.Password)
                .HasMaxLength(20)
                .IsUnicode(true)
                .IsRequired(true);

            builder.Property(ai => ai.RecoveryQuestion1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsRequired(true);

            builder.Property(ai => ai.RecoveryQuestion2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsRequired(true);

            builder.Property(ai => ai.RecoveryQuestion3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsRequired(true);

            builder.Property(ai => ai.RecoveryAnswer1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsRequired(true);

            builder.Property(ai => ai.RecoveryAnswer2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsRequired(true);

            builder.Property(ai => ai.RecoveryAnswer3)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsRequired(true);

            builder.Property(ai => ai.FirstName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsRequired(true);

            builder.Property(ai => ai.LastName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsRequired(true);

            builder.Property(ai => ai.StreetAddress)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsRequired(true);

            builder.Property(ai => ai.City)
                .HasMaxLength(75)
                .IsUnicode(false)
                .IsRequired(true);

            builder.Property(ai => ai.ZipCode)
                .HasColumnType("INT");

            builder.Property(ai => ai.Email)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsRequired(true);

            builder.Property(ai => ai.Phone)
                .HasColumnType("INT");

            builder.Property(ai => ai.IsActive)
                .HasColumnType("BIT");

            builder.Property(ai => ai.CreatedDate)
                .HasColumnType("DATETIME");

            builder.Property(ai => ai.ModifiedDate)
                .HasColumnType("DATETIME");

            builder.Property(ai => ai.ModifiedBy)
                .HasMaxLength(30)
                .IsUnicode(false);

            builder.Property(ai => ai.CreatedBy)
                .HasMaxLength(30)
                .IsUnicode(false);

        }
    }
}
