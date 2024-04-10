using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPAEntityFramework.EntityModels;
using System.Reflection.Emit;
using System.Reflection.Metadata;

namespace RPAEntityFramework.EntityTypeConfigs
{
    public class AccountInfoTypeConfig : IEntityTypeConfiguration<AccountInfo>
    {
        public void Configure(EntityTypeBuilder<AccountInfo> builder)
        {
            builder.ToTable("AccountInfo");

            builder.Property(ai => ai.AccountInfoID)
                .ValueGeneratedOnAdd();

            builder.Property(ai => ai.Username)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsRequired(true);

            builder.Property(ai => ai.Password)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsRequired(true);

            builder.Property(ai => ai.RecoveryQuestion1)
                .HasMaxLength(200)
                .IsUnicode(false)
                .IsRequired(true);

            builder.Property(ai => ai.RecoveryQuestion2)
                .HasMaxLength(200)
                .IsUnicode(false)
                .IsRequired(true);

            builder.Property(ai => ai.RecoveryQuestion3)
                .HasMaxLength(200)
                .IsUnicode(false)
                .IsRequired(true);

            builder.Property(ai => ai.RecoveryAnswer1)
                .HasMaxLength(200)
                .IsUnicode(false)
                .IsRequired(true);

            builder.Property(ai => ai.RecoveryAnswer2)
                .HasMaxLength(200)
                .IsUnicode(false)
                .IsRequired(true);

            builder.Property(ai => ai.RecoveryAnswer3)
                .HasMaxLength(200)
                .IsUnicode(false)
                .IsRequired(true);

            builder.Property(ai => ai.IsActive)
                .HasColumnType("boolean");

            builder.Property(ai => ai.RegistrationDate)
            .HasDefaultValueSql("getdate()");
        }
    }
}
