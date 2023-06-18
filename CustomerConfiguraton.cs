using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Workspace
{
    public class CustomerConfiguraton : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable(TableNameConstant.T_Customer);
            builder.HasKey(a => a.Id);

            builder.HasOne(b => b.Email);
                //.WithOne(c => c.email)

        }
    }
}
