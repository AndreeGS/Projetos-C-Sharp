using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRUD.Models.Data.DataMap
{
    public class ContaMap : IEntityTypeConfiguration<ContaModel>
    {
        public void Configure(EntityTypeBuilder<ContaModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.nomeTitular).IsRequired().HasMaxLength(255);
            builder.Property(x => x.saldoConta).IsRequired().HasMaxLength(20);
            builder.Property(x => x.dataCriacao).IsRequired().HasMaxLength(10);
            builder.Property(x => x.dataExclusao).IsRequired().HasMaxLength(10);

            
            builder.HasOne(x => x.Usuario) 
                   .WithMany()
                   .HasForeignKey(x => x.IdUsuario) 
                   .IsRequired(); 
        }
    }

}
