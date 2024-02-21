using FirstCleanArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FirstCleanArchitecture.Infrastracture.Configurations;
internal sealed class ADUserConfiguration : IEntityTypeConfiguration<ADUser>
{
    public void Configure(EntityTypeBuilder<ADUser> builder)
    {
        builder.ToTable("Users");
    }
}
