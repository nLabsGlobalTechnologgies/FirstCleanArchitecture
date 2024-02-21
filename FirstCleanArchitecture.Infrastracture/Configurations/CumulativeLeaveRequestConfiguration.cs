using FirstCleanArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FirstCleanArchitecture.Infrastracture.Configurations;

internal sealed class CumulativeLeaveRequestConfiguration : IEntityTypeConfiguration<CumulativeLeaveRequest>
{
    public void Configure(EntityTypeBuilder<CumulativeLeaveRequest> builder)
    {
        builder.ToTable("CumulativeLeaveRequests");
    }
}
